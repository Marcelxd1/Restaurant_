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
    public partial class frm_Clientes_Listar : Form
    {
        private UserWS.persona _cliente;
        private UserWS.UserWSClient daoUser;
        private Estado _estado;
        public frm_Clientes_Listar()
        {
            InitializeComponent();
            daoUser = new UserWS.UserWSClient();
            dgvListarClientes.AutoGenerateColumns = false;
            cargarTabla();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;

                    txtNombre.Enabled = false;
                    txtApellidoMaterno.Enabled = false;
                    txtApellidoPaterno.Enabled = false;
                    txtDNIRUC.Enabled = false;
                    txtRazonSocial.Enabled = false;
                    txtBuscar.Enabled = true;
                    txtRUC.Enabled = false;
                    break;

                case Estado.Modificar:
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    txtBuscar.Enabled = false;

                    txtNombre.Enabled = true;
                    break;

                case Estado.Buscar:
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;

                    txtNombre.Enabled = false;
                    txtApellidoMaterno.Enabled = false;
                    txtApellidoPaterno.Enabled = false;
                    txtDNIRUC.Enabled = false;
                    txtRazonSocial.Enabled = false;
                    txtBuscar.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtNombre.Text = "";
            txtApellidoMaterno.Text = "";
            txtApellidoPaterno.Text = "";
            txtDNIRUC.Text = "";
            txtRazonSocial.Text = "";
            txtRUC.Text = "";
            _cliente = new UserWS.persona();
        }

        private void cargarTabla()
        {
            string indicador = "";
            if (txtBuscar.Text != "Buscar")
                indicador = txtBuscar.Text;
            UserWS.persona[] personas = daoUser.listarClienteXNombre(indicador);
            if (personas != null)
                dgvListarClientes.DataSource = new BindingList<UserWS.persona>(personas);
            else
                MessageBox.Show("errooooooor", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            _cliente = (UserWS.persona)dgvListarClientes.CurrentRow.DataBoundItem;
            txtNombre.Text = _cliente.nombre;

            if (_cliente.tipo == 'N')    //si es natural
            {
                txtDNIRUC.Enabled = true;
                txtApellidoMaterno.Enabled = true;
                txtApellidoPaterno.Enabled = true;
                txtApellidoMaterno.Text = _cliente.apellido_materno;
                txtApellidoPaterno.Text = _cliente.apellido_paterno;
                txtDNIRUC.Text = _cliente.DNI;

            }
            else                        //si es juridico
            {
                
                txtRazonSocial.Enabled = true;
                txtRUC.Enabled = true;
                txtRUC.Text = _cliente.ruc;
                txtRazonSocial.Text = _cliente.razon_social;
            }
            establecerEstadoComponentes();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _cliente = (UserWS.persona)dgvListarClientes.CurrentRow.DataBoundItem;
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar esta categoría?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                int resultado = daoUser.elminarPersona(_cliente.id_persona);
                if (resultado != 0)
                    MessageBox.Show("Se ha eliminado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //*************

                cargarTabla();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_cliente.tipo == 'N')
            {
                if (txtDNIRUC.Text.Trim().Length != 8)
                {
                    MessageBox.Show("El DNI ingresado debe tener 8 dígitos", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    Int32.Parse(txtDNIRUC.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El DNI debe ser un número", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtApellidoPaterno.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un apellido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtApellidoMaterno.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un apellido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _cliente.DNI = txtDNIRUC.Text.Trim();
                _cliente.apellido_paterno = txtApellidoPaterno.Text.Trim();
                _cliente.apellido_materno = txtApellidoMaterno.Text.Trim();
            }
            else
            {
                if (txtRUC.Text.Trim().Length != 11)
                {
                    MessageBox.Show("El RUC ingresado debe tener 11 dígitos", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    Int64.Parse(txtRUC.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El RUC debe ser un número", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtRazonSocial.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar la razón social", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _cliente.ruc = txtRUC.Text.Trim();
                _cliente.razon_social = txtRazonSocial.Text.Trim();
            }

            _cliente.nombre = txtNombre.Text.Trim();
            if (_estado == Estado.Modificar)
            {
                int resultado = daoUser.modificarPersona(_cliente);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    cargarTabla();
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Ha ocurrido un error con la modificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvListarClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            UserWS.persona cliente = (UserWS.persona)dgvListarClientes.Rows[e.RowIndex].DataBoundItem;
            dgvListarClientes.Rows[e.RowIndex].Cells[0].Value = cliente.id_persona;
            if (cliente.tipo == 'N')
            {
                dgvListarClientes.Rows[e.RowIndex].Cells[1].Value = "Persona";
                dgvListarClientes.Rows[e.RowIndex].Cells[2].Value = cliente.DNI;
                dgvListarClientes.Rows[e.RowIndex].Cells[3].Value =
                    cliente.nombre + " " + cliente.apellido_paterno + " " + cliente.apellido_materno;
            }
            else
            {
                dgvListarClientes.Rows[e.RowIndex].Cells[1].Value = "Empresa";
                dgvListarClientes.Rows[e.RowIndex].Cells[2].Value = cliente.ruc;
                dgvListarClientes.Rows[e.RowIndex].Cells[3].Value =
                    cliente.nombre;
            }
        } 

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsLetter(e.KeyChar)) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsLetter(e.KeyChar)) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsLetter(e.KeyChar)) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsLetter(e.KeyChar)) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtDNIRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private void txtBuscar_DoubleClick(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void txtBuscar_IconRightClick(object sender, EventArgs e)
        {
            cargarTabla();
        }

        
    }
}
