using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public frm_Gestion_Productos_RegistroCategoria()
        {
            InitializeComponent();
            daoNegocio = new NegocioWS.NegocioWSClient();
            dgvListar.AutoGenerateColumns = false;
            //dgvListar.DataSource = daoNegocio.listarTodasCategorias();
            
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
                    btnImgListar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;

                    txtDescripcion.Enabled = false;
                    txtNombre.Enabled = false;
                    dgvListar.Enabled = false;
                    break;
                case Estado.Modificar:
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnImgListar.Enabled = false;

                    txtDescripcion.Enabled = true;
                    txtNombre.Enabled = true;
                    dgvListar.Enabled = false;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnImgListar.Enabled = true;

                    txtDescripcion.Enabled = false;
                    txtNombre.Enabled = false;
                    dgvListar.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            _categoria = new NegocioWS.categoria();
            //dgvListar.AutoGenerateColumns = false;
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
    }
}
