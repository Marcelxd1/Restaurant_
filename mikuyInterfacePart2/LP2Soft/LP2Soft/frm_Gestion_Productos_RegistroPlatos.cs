using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class frm_Gestion_Productos_RegistroPlatos : Form
    {
        private Estado _estado;
        private NegocioWS.producto _producto;
        private NegocioWS.producto prodSelecciona;
        private NegocioWS.NegocioWSClient daoNegocio;
        private string _rutaFotoPortada;

        public frm_Gestion_Productos_RegistroPlatos(Estado estado, NegocioWS.producto producto)
        {
            InitializeComponent();
            daoNegocio = new NegocioWS.NegocioWSClient();
            cbCategoria.DataSource = daoNegocio.listarTodasCategorias();
            cbCategoria.DisplayMember = "nombre";
            cbCategoria.ValueMember = "idCategoria";
            _estado = estado;
            prodSelecciona = producto;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnGuardar.Enabled = false;
                    btnSubirFoto.Enabled = false;
                    txtNombre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtPresentacion.Enabled = false;
                    rbBebida.Enabled = false;
                    rbPlato.Enabled = false;
                    cbCategoria.Enabled = false;
                    break;
                case Estado.Modificar:
                    btnGuardar.Enabled = true;
                    btnSubirFoto.Enabled = true;
                    txtNombre.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtPresentacion.Enabled = true;
                    rbBebida.Enabled = true;
                    rbPlato.Enabled = true;
                    cbCategoria.Enabled = true;
                    btnGuardar.Text = "Modificar";
                    completaDatos();
                    break;
                case Estado.Nuevo:
                    btnGuardar.Enabled = true;
                    btnSubirFoto.Enabled=true;
                    txtNombre.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtPresentacion.Enabled = false;
                    rbBebida.Enabled = true;
                    rbPlato.Enabled = true;
                    cbCategoria.Enabled = true;
                    btnGuardar.Text = "Registrar";
                    break;

            }
        }

        public void limpiarComponentes()
        {
            epNombre.SetError(txtNombre, "");
            epDescripcion.SetError(txtDescripcion, "");
            epPrecio.SetError(txtPrecio, "");
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtPresentacion.Text = "";
            pbPlato.Image = null;
            rbBebida.Checked = false;
            rbPlato.Checked = false;
            _producto = new NegocioWS.producto();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
                this.DialogResult = DialogResult.Cancel;
                this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (verificarDatos())
            {
                _producto.nombre = txtNombre.Text.Trim();
                _producto.precio = Double.Parse(txtPrecio.Text.Trim());
                _producto.descripcion = txtDescripcion.Text.Trim();
                if (rbBebida.Checked)
                {
                    _producto.tipoProducto = 'B';
                    _producto.presentacion = txtPresentacion.Text.Trim();
                }
                else
                {
                    _producto.tipoProducto = 'C';
                    _producto.presentacion = null;
                }
                _producto.categoria = (NegocioWS.categoria)cbCategoria.SelectedItem;
                if (_estado == Estado.Nuevo)
                {
                    int resultado = daoNegocio.insertarProducto(_producto);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha registrado correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _estado = Estado.Nuevo;
                        limpiarComponentes();
                        establecerEstadoComponentes();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (_estado == Estado.Modificar)
                {
                    _producto.idItemVendible = prodSelecciona.idItemVendible;
                    int resultado = daoNegocio.modificarProducto(_producto);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha modificado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con la modificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { return; }

        }
        

        private void rbBebida_CheckedChanged(object sender, EventArgs e)
        {
            txtPresentacion.Enabled = rbBebida.Checked;
        }

        private void completaDatos()
        {
            //prodSelecciona = (NegocioWS.producto)dgvProductos.CurrentRow.DataBoundItem;
            txtNombre.Text = prodSelecciona.nombre;
            txtDescripcion.Text = prodSelecciona.descripcion;
            txtPrecio.Text = prodSelecciona.precio.ToString("N2");
            if(prodSelecciona.imagen != null) { 
                MemoryStream ms = new MemoryStream(prodSelecciona.imagen);
                pbPlato.Image = new Bitmap(ms);
            }
            else pbPlato.Image = null;
            if (prodSelecciona.tipoProducto == 'B')
            {
                rbBebida.Checked = true;
                //rbPlato.Checked = true;
                txtPresentacion.Text = prodSelecciona.presentacion;
            }
            else
            {
                rbPlato.Checked= true;
                txtPresentacion.Text = "";
            }
            cbCategoria.SelectedValue = prodSelecciona.categoria.idCategoria;
        }

        

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFotos.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoPortada = ofdFotos.FileName;
                    pbPlato.Image = Image.FromFile(_rutaFotoPortada);
                    FileStream fs = new FileStream(_rutaFotoPortada, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    this._producto.imagen = br.ReadBytes((int)fs.Length);
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        

        // Restricciones para los caracteres de los campos TXT 
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        // Validar que se completen campos

        private bool  verificarDatos() {
        
            if(txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtPrecio.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un precio", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una descripción", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (rbBebida.Checked && txtPresentacion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una presentación", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }
        private void txtPrecio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtPrecio.Text.Trim() == "")
            {
                epPrecio.SetError(txtPrecio, "Debe ingresar el precio");
            }
            else
                epPrecio.SetError(txtPrecio, "");
        }

        private void txtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                epNombre.SetError(txtNombre, "Debe ingresar un nombre");
            }
            else
                epNombre.SetError(txtNombre, "");
        }

        private void txtDescripcion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtDescripcion.Text.Trim() == "")
            {
                epDescripcion.SetError(txtDescripcion, "Debe ingresar una descripción");
            }
            else
                epDescripcion.SetError(txtDescripcion, "");
        }

        private void rbBebida_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (rbBebida.Checked == false && rbPlato.Checked == false)
            {
                epTipo.SetError(rbBebida, "Debe seleccionar un tipo");
            }
            else
                epTipo.SetError(rbBebida, "");
        }

        private void rbPlato_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (rbBebida.Checked == false && rbPlato.Checked == false)
            {
                epTipo.SetError(rbBebida, "Debe seleccionar un tipo");
            }
            else
                epTipo.SetError(rbBebida, "");
        }

        
    }
}
