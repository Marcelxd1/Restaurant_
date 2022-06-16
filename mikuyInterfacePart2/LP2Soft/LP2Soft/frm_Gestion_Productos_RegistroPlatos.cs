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
        private NegocioWS.NegocioWSClient daoNegocio;
        private string _rutaFotoPortada;

        public frm_Gestion_Productos_RegistroPlatos()
        {
            InitializeComponent();
            daoNegocio = new NegocioWS.NegocioWSClient();
            dgvProductos.AutoGenerateColumns = false;
            cargarTabla();
            cbCategoria.DataSource = daoNegocio.listarTodasCategorias();
            cbCategoria.DisplayMember = "nombre";
            cbCategoria.ValueMember = "idCategoria";
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnSubirFoto.Enabled = false;
                    btnEliminar.Enabled = true;
                    txtNombre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtPresentacion.Enabled = false;
                    rbBebida.Enabled = false;
                    rbPlato.Enabled = false;
                    cbCategoria.Enabled = false;
                    break;
                case Estado.Modificar:
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnSubirFoto.Enabled=true;
                    txtNombre.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtPresentacion.Enabled = false;
                    rbBebida.Enabled = true;
                    rbPlato.Enabled = true;
                    cbCategoria.Enabled = true;
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
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
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
                        _estado = Estado.Inicial;
                        establecerEstadoComponentes();
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (_estado == Estado.Modificar)
                {
                    int resultado = daoNegocio.modificarProducto(_producto);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha modificado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _estado = Estado.Inicial;
                        establecerEstadoComponentes();
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con la modificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cargarTabla();
            }
            else { return; }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _producto = (NegocioWS.producto)dgvProductos.CurrentRow.DataBoundItem;
            int resultado = daoNegocio.eliminarProducto(_producto.idProducto);
            
            if (resultado != 0)
            {
                MessageBox.Show("Se ha eliminado correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            }
            else
                MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cargarTabla();
        }

        private void rbBebida_CheckedChanged(object sender, EventArgs e)
        {
            txtPresentacion.Enabled = rbBebida.Checked;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _producto = (NegocioWS.producto)dgvProductos.CurrentRow.DataBoundItem;
            txtNombre.Text = _producto.nombre;
            txtDescripcion.Text = _producto.descripcion;
            txtPrecio.Text = _producto.precio.ToString("N2");
            if(_producto.imagen != null) { 
                MemoryStream ms = new MemoryStream(_producto.imagen);
                pbPlato.Image = new Bitmap(ms);
            }
            else pbPlato.Image = null;
            if (_producto.tipoProducto == 'B')
            {
                rbBebida.Checked = true;
                //rbPlato.Checked = true;
                txtPresentacion.Text = _producto.presentacion;
            }
            else
            {
                rbPlato.Checked= true;
                txtPresentacion.Text = "";
            }
            cbCategoria.SelectedValue = _producto.categoria.idCategoria;
            _estado = Estado.Modificar;
            establecerEstadoComponentes();
        }

        private void txtBuscar_DoubleClick(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void txtBuscar_IconRightClick(object sender, EventArgs e)
        {
            cargarTabla();
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

        private void cargarTabla()
        {
            string indicador = "";
            if(txtBuscar.Text != "Buscar")
                indicador = txtBuscar.Text;
            NegocioWS.producto[] productos = daoNegocio.listarProductoXNombre(indicador);
            if (productos != null)
                dgvProductos.DataSource = new BindingList<NegocioWS.producto>(productos);
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
