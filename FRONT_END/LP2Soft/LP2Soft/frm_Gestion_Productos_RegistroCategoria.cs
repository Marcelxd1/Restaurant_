using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class frm_Gestion_Productos_RegistroCategoria : Form
    {
        private NegocioWS.categoria _categoria;
        private NegocioWS.NegocioWSClient daoNegocio;
        private Estado _estado;
        private string _rutaFotoPortada;
        public frm_Gestion_Productos_RegistroCategoria()
        {
            InitializeComponent();
            daoNegocio = new NegocioWS.NegocioWSClient();
            dgvListar.AutoGenerateColumns = false;
            
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarComponentes();
            cargarTabla();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = false;

                    txtDescripcion.Enabled = false;
                    txtNombre.Enabled = false;
                    pbIcono.Enabled = false;
                    pbIcono.Text = "ÍCONO";
                    epNombre.SetError(txtNombre, "");
                    break;
                case Estado.Modificar:
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;

                    txtDescripcion.Enabled = true;
                    txtNombre.Enabled = true;
                    pbIcono.Enabled=true;

                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;

                    txtDescripcion.Enabled = false;
                    txtNombre.Enabled = false;
                    break;
            }
        }

        private void cargarTabla()
        {

            dgvListar.DataSource = daoNegocio.listarTodasCategorias();
        }

        public void limpiarComponentes()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            _categoria = new NegocioWS.categoria();
            
            //dgvListar.AutoGenerateColumns = false;
            epNombre.SetError(txtNombre, "");
            
            this.pbIcono.Image = global::LP2Soft.Properties.Resources.newImagen;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length >= 100)
            {
                MessageBox.Show("El nombre ingresado tiene más de 100 caracteres", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDescripcion.Text.Trim().Length >= 100)
            {
                MessageBox.Show("La descripción ingresada tiene más de 100 caracteres", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _categoria.nombre = txtNombre.Text;
            _categoria.descripcion = txtDescripcion.Text;

            if(_estado == Estado.Nuevo)
            {
                int resultado = daoNegocio.insertarCategoria(_categoria);
                if(resultado != 0)
                {
                    MessageBox.Show("Se ha registrado correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                    cargarTabla();
                }
                else
                    MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(_estado == Estado.Modificar)
            {
                int resultado = daoNegocio.modificarCategoria(_categoria);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    dgvListar.DataSource = daoNegocio.listarTodasCategorias();
                    limpiarComponentes();
                    establecerEstadoComponentes();
                    cargarTabla();
                }
                else
                    MessageBox.Show("Ha ocurrido un error con la modificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            _categoria = (NegocioWS.categoria)dgvListar.CurrentRow.DataBoundItem;
            txtDescripcion.Text = _categoria.descripcion;
            txtNombre.Text = _categoria.nombre;
            pbIcono.Text = _categoria.nombre;
            if (_categoria.icono != null)
            {
                MemoryStream ms = new MemoryStream(_categoria.icono);
                pbIcono.Image = new Bitmap(ms);
            }
            establecerEstadoComponentes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _categoria = (NegocioWS.categoria)dgvListar.CurrentRow.DataBoundItem;
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar esta categoría?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                int resultado = daoNegocio.eliminarCategoria(_categoria.idCategoria);
                if (resultado != 0)
                    MessageBox.Show("Se ha eliminado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                dgvListar.DataSource = daoNegocio.listarTodasCategorias();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnImgListar_Click(object sender, EventArgs e)
        {
            dgvListar.DataSource = daoNegocio.listarTodasCategorias();
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void txtNombre_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                epNombre.SetError(txtNombre, "Debe ingresar el nombre");
            }
            else
                epNombre.SetError(txtNombre, "");
        }

        private void pbIcono_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFotos.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoPortada = ofdFotos.FileName;
                    pbIcono.Image = Image.FromFile(_rutaFotoPortada);
                    FileStream fs = new FileStream(_rutaFotoPortada, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    this._categoria.icono = br.ReadBytes((int)fs.Length);
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (pbIcono.Text != "")
                pbIcono.Text = txtNombre.Text;
            else
                pbIcono.Text = "ÌCONO";
        }
    }
}
