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
        private bool emp = false;
        private bool per = true;
        private BindingList<UserWS.sector> sects;

        public persona ClienteSeleccionado { get => _clienteSeleccionado; set => _clienteSeleccionado = value; }
        public int Dato { get => dato; set => dato = value; }

        public frm_Clientes_Registrar(Estado estado, UserWS.persona ppersona)
        {
            InitializeComponent();
            _estado = estado;
            daoUser = new UserWS.UserWSClient();
            _clienteSeleccionado = new UserWS.persona();
            _clienteSeleccionado = ppersona;
            UserWS.sector sector = new UserWS.sector();
            sects = new BindingList<UserWS.sector>();
            sects = new BindingList<UserWS.sector>(daoUser.listarSectores().ToList());
            sector.id_sector = 0;
            sector.descripcion = "TODOS";
            sects.Insert(0, sector);
            cbSector.DataSource = sects;
            cbSector.DisplayMember = "descripcion";
            cbSector.ValueMember = "id_sector";
            cbActividad.DataSource = daoUser.listarActividadesXSector(0).ToList();
            cbActividad.DisplayMember = "descripcion";
            cbActividad.ValueMember = "id_actividad";
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Nuevo:
                    btnRegistrar.Enabled = true;
                    btnCancelar.Enabled = true;

                    txtNombre.Enabled = true;
                    txtApellidoPaterno.Enabled = true;
                    txtApellidoMaterno.Enabled = true;
                    txtDNI.Enabled = true;
                    txtRuc.Enabled = true;
                    txtRazon.Enabled = true;
                    btnRegistrar.Text = "Registrar";
                    limpiarComponentes();
                    break;

                case Estado.Inicial:
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

                case Estado.Modificar:
                    btnRegistrar.Enabled = true;
                    btnCancelar.Enabled = true;

                    txtNombre.Enabled = true;
                    txtApellidoPaterno.Enabled = true;
                    txtApellidoMaterno.Enabled = true;
                    txtDNI.Enabled = true;
                    txtRuc.Enabled = true;
                    txtRazon.Enabled = true;
                    btnRegistrar.Text = "Modificar";
                    llenarDatos();
                    break;
            }
        }

        private void llenarDatos()
        {
            txtNombre.Text = _clienteSeleccionado.nombre;

            if (_clienteSeleccionado.tipo == 'N')    //si es natural
            {
                per = true;
                emp = false;
                EstablecerPersona();
                txtApellidoMaterno.Text = _clienteSeleccionado.apellido_materno;
                txtApellidoPaterno.Text = _clienteSeleccionado.apellido_paterno;
                txtDNI.Text = _clienteSeleccionado.DNI;
            }
            else                        //si es juridico
            {
                per = false;
                emp = true;
                EstablecerPersona();
                txtRuc.Text = _clienteSeleccionado.ruc;
                cbSector.SelectedIndex = _clienteSeleccionado.actividad.sector.id_sector;
                int i = 0;
                foreach (UserWS.actividad act in cbActividad.Items)
                {
                    if(act.id_actividad == _clienteSeleccionado.actividad.id_actividad)
                    {
                        cbActividad.SelectedIndex = i;
                        break;
                    }
                    i++;
                }
                txtRazon.Text = _clienteSeleccionado.razon_social;
            }
            if(_clienteSeleccionado.VIP == true)
                cbVIP.Checked = true;
            if(_clienteSeleccionado.asociado == true)
                cbAsociado.Checked = true;
        }

        private void EstablecerPersona()
        {
            if(per == true)
            {
                txtNombre.Show();
                lblNombre.Show();
                txtApellidoPaterno.Show();
                lblApellidoPaterno.Text = "Apellido Paterno";
                lblApellidoPaterno.Show();
                txtApellidoMaterno.Show();
                lblApellidoMaterno.Text = "Apellido Materno";
                lblApellidoMaterno.Show();
                txtDNI.Show();
                lblDNI.Show();
                txtRuc.Hide();
                lblRuc.Hide();
                txtRazon.Hide();
                lblRazon.Hide();
                cbSector.Hide();
                cbActividad.Hide();
                btnPersona.BackColor = Color.SlateBlue;
                btnEmpresa.BackColor = Color.WhiteSmoke;
            }
            else
            {
                txtNombre.Show();
                lblNombre.Show();
                txtApellidoPaterno.Hide();
                lblApellidoPaterno.Show();
                lblApellidoPaterno.Text = "Sector";
                txtApellidoMaterno.Hide();
                lblApellidoMaterno.Show();
                lblApellidoMaterno.Text = "Actividad";
                txtDNI.Hide();
                lblDNI.Hide();
                txtRuc.Show();
                lblRuc.Show();
                txtRazon.Show();
                lblRazon.Show();
                cbSector.Show();
                cbActividad.Show();
                btnPersona.BackColor = Color.WhiteSmoke;
                btnEmpresa.BackColor = Color.SlateBlue;
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
            cbAsociado.Checked = false;
            cbVIP.Checked = false;
            _cliente = new UserWS.persona();
            cbSector.SelectedIndex = 0;
            epRazon.SetError(txtRazon, "");
            epApMaterno.SetError(txtRazon, "");
            epApPaterno.SetError(txtRazon, "");
            epDNI.SetError(txtRazon, "");
            epRUC.SetError(txtRazon, "");
            per = true;
            emp = false;
            EstablecerPersona();
        }

        private void rbPersona_CheckedChanged(object sender, EventArgs e)
        {
            
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
            if (per == true && emp == false)
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
                    MessageBox.Show("Debe ingresar un apellido paterno", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtApellidoMaterno.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un apellido materno", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _cliente.DNI = txtDNI.Text.Trim();
                _cliente.apellido_paterno = txtApellidoPaterno.Text.Trim().ToUpper();
                _cliente.apellido_materno = txtApellidoMaterno.Text.Trim().ToUpper();
                _cliente.tipo = 'N';
            }
            else if(emp == true && per == false)
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
                _cliente.razon_social = txtRazon.Text.Trim().ToUpper();
                _cliente.actividad = (UserWS.actividad)cbActividad.SelectedItem;
                _cliente.tipo = 'J';
            }

            _cliente.nombre = txtNombre.Text.Trim().ToUpper();
            _cliente.VIP = cbVIP.Checked;
            _cliente.asociado = cbAsociado.Checked;
            if(_estado == Estado.Nuevo)
            {
                int resultado;
                if (_cliente.tipo == 'J')
                {
                    resultado = daoUser.insertarEmpresa(_cliente);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha registrado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _estado = Estado.Nuevo;
                        this.DialogResult = DialogResult.OK;
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
                        _estado = Estado.Nuevo;
                        this.DialogResult=DialogResult.OK;
                        establecerEstadoComponentes();
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if(_estado == Estado.Modificar)
            {
                int resultado;
                if (_cliente.tipo == 'J')
                {
                    resultado = daoUser.modificarEmpresa(_cliente);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha modificado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con la modificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (_cliente.tipo == 'N')
                {
                    resultado = daoUser.modificarPersona(_cliente);
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_estado == Estado.Nuevo)
            {
                _estado = Estado.Nuevo;
                limpiarComponentes();
                establecerEstadoComponentes();
            }
            else if(_estado == Estado.Modificar)
            {
                this.DialogResult=DialogResult.OK;
                this.Close();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsLetter(e.KeyChar)) && (e.KeyChar != ' ') )
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

        private void lblDNI_Click(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRuc_Click(object sender, EventArgs e)
        {

        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            if (emp == false)
            {
                emp = true;
                per = false;
                EstablecerPersona();
            }
            
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            if (per == false)
            {
                per = true;
                emp = false;
                EstablecerPersona();
            }
        }

        private void cbSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbActividad.DataSource = daoUser.listarActividadesXSector(cbSector.SelectedIndex);
        }

    }
}
