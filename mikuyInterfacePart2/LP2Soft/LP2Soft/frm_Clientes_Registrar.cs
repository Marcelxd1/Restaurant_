using LP2Soft.UserWS;
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
    public partial class frm_Clientes_Registrar : Form
    {
        private UserWS.persona _cliente;
        private UserWS.persona _clienteSeleccionado;
        private UserWS.UserWSClient daoUser;
        private Estado _estado;
        private int dato = 0;

        public persona ClienteSeleccionado { get => _clienteSeleccionado; set => _clienteSeleccionado = value; }
        public int Dato { get => dato; set => dato = value; }

        public frm_Clientes_Registrar()
        {
            InitializeComponent();
            daoUser = new UserWS.UserWSClient();
            _clienteSeleccionado = new UserWS.persona();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Nuevo:
                    rbEmpresa.Enabled = true;
                    rbPersona.Enabled = true;
                    btnRegistrar.Enabled = true;
                    btnCancelar.Enabled = true;

                    txtNombre.Enabled = false;
                    txtApellidoPaterno.Enabled = false;
                    txtApellidoMaterno.Enabled = false;
                    txtDNI.Enabled = false;
                    txtRuc.Enabled = false;
                    txtRazon.Enabled = false;

                    txtNombre.Show() ;
                    lblNombre.Show() ;
                    txtApellidoPaterno.Show() ;
                    lblApellidoPaterno.Show();
                    txtApellidoMaterno.Show() ;
                    lblApellidoMaterno.Show();
                    txtDNI.Show() ;
                    lblDNI.Show() ;
                    txtRuc.Show() ;
                    lblRuc.Show();
                    txtRazon.Show();
                    lblRazon.Show();
                    break;

                case Estado.Inicial:
                    rbEmpresa.Enabled = true;
                    rbPersona.Enabled = true;
                    btnRegistrar.Enabled = false;
                    btnCancelar.Enabled = false;

                    txtNombre.Enabled = false;
                    txtApellidoPaterno.Enabled = false;
                    txtApellidoMaterno.Enabled = false;
                    txtDNI.Enabled = false;
                    txtRuc.Enabled = false;
                    txtRazon.Enabled = false;

                    txtNombre.Show();
                    lblNombre.Show();
                    txtApellidoPaterno.Show();
                    lblApellidoPaterno.Show();
                    txtApellidoMaterno.Show();
                    lblApellidoMaterno.Show();
                    txtDNI.Show();
                    lblDNI.Show();
                    txtRuc.Show();
                    lblRuc.Show();
                    txtRazon.Show();
                    lblRazon.Show();
                    limpiarComponentes();
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtDNI.Text = "";
            txtRuc.Text = "";
            txtRazon.Text = "";
            _cliente = new UserWS.persona();
        }

        private void rbPersona_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPersona.Checked) { 
                _estado = Estado.Nuevo;
                establecerEstadoComponentes();
                txtNombre.Enabled = true;
                txtApellidoPaterno.Enabled = true;
                txtApellidoMaterno.Enabled = true;
                txtDNI.Enabled = true;
                lblRuc.Hide();
                txtRuc.Hide();
                lblRazon.Hide();
                txtRazon.Hide();
            }
            else
            {
                _estado = Estado.Nuevo;
                establecerEstadoComponentes();
                txtNombre.Enabled = true;
                txtRuc.Enabled = true;
                txtRazon.Enabled = true;
                txtApellidoPaterno.Hide();
                lblApellidoPaterno.Hide();
                txtApellidoMaterno.Hide();
                lblApellidoMaterno.Hide();
                txtDNI.Hide();
                lblDNI.Hide();
            }
        }

        private void rbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbPersona.Checked == true && rbEmpresa.Checked == false)
            {

                if (txtDNI.Text.Trim().Length != 8)
                {
                    MessageBox.Show("El DNI ingresado debe tener 8 dígitos", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    Int32.Parse(txtDNI.Text);
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
                _cliente.DNI = txtDNI.Text.Trim();
                _cliente.apellido_paterno = txtApellidoPaterno.Text.Trim();
                _cliente.apellido_materno = txtApellidoMaterno.Text.Trim();
                _cliente.tipo = 'N';
            }
            else if(rbEmpresa.Checked == true && rbPersona.Checked == false)
            {
                if (txtRuc.Text.Trim().Length != 11)
                {
                    MessageBox.Show("El RUC ingresado debe tener 11 dígitos", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    Int64.Parse(txtRuc.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El RUC debe ser un número", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtRazon.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar la razón social", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _cliente.ruc = txtRuc.Text.Trim();
                _cliente.razon_social = txtRazon.Text.Trim();
                _cliente.tipo = 'J';
            }

            _cliente.nombre = txtNombre.Text.Trim();
            if(true)
            {
                int resultado;
                if (_cliente.tipo == 'J')
                {
                    resultado = daoUser.insertarEmpresa(_cliente);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha registrado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _estado = Estado.Inicial;
                        _clienteSeleccionado = _cliente;
                        if(dato == 1)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        establecerEstadoComponentes();
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if(_cliente.tipo == 'N')
                {
                    resultado = daoUser.insertarPersona(_cliente);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha registrado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _estado = Estado.Inicial;

                        establecerEstadoComponentes();
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
            epNombre.SetError(txtNombre, "");
            epApPaterno.SetError(txtApellidoPaterno, "");
            epApMaterno.SetError(txtApellidoMaterno, "");
            epDNI.SetError(txtDNI, "");
            epRazon.SetError(txtRazon, "");
            epRUC.SetError(txtRuc, "");
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

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRazon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsLetter(e.KeyChar)) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                epNombre.SetError(txtNombre, "Debe ingresar el nombre");
            }
            else
                epNombre.SetError(txtNombre, "");
        }

        private void txtApellidoPaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoPaterno.Text.Trim() == "")
            {
                epApPaterno.SetError(txtApellidoPaterno, "Debe ingresar el apellido paterno");
            }
            else
                epApPaterno.SetError(txtApellidoPaterno, "");
        }

        private void txtApellidoMaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoMaterno.Text.Trim() == "")
            {
                epApMaterno.SetError(txtApellidoMaterno, "Debe ingresar el apellido materno");
            }
            else
                epApMaterno.SetError(txtApellidoMaterno, "");
        }

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            if (txtDNI.Text.Trim() == "")
            {
                epDNI.SetError(txtDNI, "Debe ingresar el DNI");
            }
            else
                epDNI.SetError(txtDNI, "");
        }

        private void txtRazon_Validating(object sender, CancelEventArgs e)
        {
            if (txtRazon.Text.Trim() == "")
            {
                epRazon.SetError(txtRazon, "Debe ingresar la razón social");
            }
            else
                epRazon.SetError(txtRazon, "");
        }

        private void txtRuc_Validating(object sender, CancelEventArgs e)
        {
            if (txtRuc.Text.Trim() == "")
            {
                epRUC.SetError(txtRuc, "Debe ingresar el RUC");
            }
            else
                epRUC.SetError(txtRuc, "");
        }
    }
}
