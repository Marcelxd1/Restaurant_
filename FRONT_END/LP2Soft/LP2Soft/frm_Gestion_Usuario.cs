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
    public partial class frm_Gestion_Usuario : Form
    {
        private string _rutaFoto;
        private UserWS.UserWSClient daoUser;
        private UserWS.usuario _usuario;
        private UserWS.usuario _usuarioSeleccionado;
        private Estado _estado;
        private bool flagFoto = false;

        public frm_Gestion_Usuario(Estado estado, UserWS.usuario user)
        {
            InitializeComponent();
            _estado = estado;
            daoUser = new UserWS.UserWSClient();    
            _usuario = new UserWS.usuario();
            cmbRol.DataSource = daoUser.listarRolTodos();
            cmbRol.DisplayMember = "descripcion";
            cmbRol.ValueMember = "id_rol";
            cmbRol.SelectedIndex = -1; 
            _usuarioSeleccionado = new UserWS.usuario();
            _usuarioSeleccionado = user;
            flagFoto = false;
            establecerEstadoComponentes();
        }

        public UserWS.usuario UsuarioSeleccionado { get => _usuarioSeleccionado; set => _usuarioSeleccionado = value; }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                
                case Estado.Modificar:
                    completarDatos();
                    btnRegistrar.Text = "Modificar";
                    btnSubirFoto.Enabled = true;
                    btnRegistrar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellidoMaterno.Enabled = true;
                    txtApellidoPaterno.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtDNI.Enabled = true;
                    txtPassword.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtUsername.Enabled = true;
                    cmbRol.Enabled = true;
                    break;
                case Estado.Nuevo:
                    limpiarComponentes();
                    btnRegistrar.Text = "Registrar";
                    btnSubirFoto.Enabled = true;
                    btnRegistrar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellidoMaterno.Enabled = true;
                    txtApellidoPaterno.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtDNI.Enabled = true;
                    txtPassword.Enabled = true;    
                    txtTelefono.Enabled = true;
                    txtUsername.Enabled = true;
                    cmbRol.Enabled = true;
                    break;

            }
        }

        private void completarDatos()
        {
            txtNombre.Text = _usuarioSeleccionado.nombre;
            txtApellidoMaterno.Text = _usuarioSeleccionado.apellido_paterno;
            txtApellidoPaterno.Text = _usuarioSeleccionado.apellido_materno;
            txtCorreo.Text = _usuarioSeleccionado.correo;
            txtDNI.Text = _usuarioSeleccionado.DNI;
            txtPassword.Text = _usuarioSeleccionado.password;
            txtTelefono.Text = _usuarioSeleccionado.telefono;
            txtUsername.Text = _usuarioSeleccionado.usuario1;
            cmbRol.SelectedIndex = _usuarioSeleccionado.rol.id_rol-1;
            txtSueldo.Text = _usuarioSeleccionado.salario.ToString();
            txtPassword.Text = _usuarioSeleccionado.password;
            if (_usuarioSeleccionado.imagen != null)
            {
                MemoryStream ms = new MemoryStream(_usuarioSeleccionado.imagen);
                pbFoto.Image = new Bitmap(ms);
            }
            else pbFoto.Image = null;
        }

        private void limpiarComponentes()
        {
            txtNombre.Text = "";
            txtApellidoMaterno.Text = "";
            txtApellidoPaterno.Text = "";
            txtCorreo.Text = "";
            txtDNI.Text = "";
            txtPassword.Text = "";
            txtPasswordConfirm.Text = "";
            txtSueldo.Text = "";
            txtTelefono.Text = "";
            txtUsername.Text = "";
            epApeMater.SetError(txtApellidoMaterno, "");
            epApePater.SetError(txtApellidoPaterno, "");
            epContraseña.SetError(txtPassword, "");
            epCorreo.SetError(txtCorreo, "");
            epDNI.SetError(txtDNI, "");
            epNombre.SetError(txtNombre, "");
            epSueldo.SetError(txtSueldo, "");
            epTelefono.SetError(txtTelefono, "");
            epUsername.SetError(txtUsername, "");
            cmbRol.SelectedIndex = -1;
            pbFoto.Image = null;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text.Trim().Length != 8)
            {
                MessageBox.Show("El DNI ingresado debe tener 8 digitos", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Int32.Parse(txtDNI.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("El DNI debe ser un número", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Nombre", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellidoPaterno.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Apellido PATERNO", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellidoMaterno.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Apellido MATERNO", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("No se ha ingresado un password", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtPasswordConfirm.Text.Trim() == "")
            {
                MessageBox.Show("Confirme su password", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSueldo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un sueldo para el usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Double.Parse(txtSueldo.Text);   
            }catch (Exception ex)
            {
                MessageBox.Show("No ha ingresado correctamente el sueldo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un telefono", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese su usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pbFoto.Image == null)
            {
                MessageBox.Show("Ingrese una imagen para el usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese su correo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo valido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string pass1 = txtPassword.Text.Trim();
            string pass2 = txtPasswordConfirm.Text.Trim();
            if (pass1 != pass2)
            {
                MessageBox.Show("La confirmacion del password no es la misma", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _usuario.apellido_materno = txtApellidoMaterno.Text.Trim().ToUpper();
            _usuario.apellido_paterno = txtApellidoPaterno.Text.Trim().ToUpper();
            _usuario.DNI   = txtDNI.Text.Trim();
            _usuario.nombre = txtNombre.Text.Trim().ToUpper();
            _usuario.rol = (UserWS.rol)cmbRol.SelectedItem;
            _usuario.salario = Double.Parse(txtSueldo.Text.Trim());
            _usuario.telefono = txtTelefono.Text.Trim();
            _usuario.usuario1 = txtUsername.Text.Trim();
            _usuario.password = pass1; 
            _usuario.correo = txtCorreo.Text.Trim();
            if (_estado == Estado.Nuevo)
            {
                int resultado = daoUser.insertarUsuario(_usuario);
                if (resultado > 0)
                {
                    MessageBox.Show("Se ha registrado correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Nuevo;
                    establecerEstadoComponentes();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (_estado == Estado.Modificar)
            {
                _usuario.id_usuario = _usuarioSeleccionado.id_usuario;
                if (flagFoto == false)
                    _usuario.imagen = _usuarioSeleccionado.imagen;
                int resultado = daoUser.modificarUsuarioTodos(_usuario);
                if (resultado > 0)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Nuevo;
                    establecerEstadoComponentes();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error con la modificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(_rutaFoto);
                    FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    _usuario.imagen = br.ReadBytes((int)fs.Length);
                    fs.Close();
                    if(_estado == Estado.Modificar)
                    {
                        flagFoto = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            if(_estado == Estado.Modificar)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //VALIDACIONES ===========================================================================

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
                epApePater.SetError(txtApellidoPaterno, "Debe ingresar el apellido paterno");
            }
            else
                epApePater.SetError(txtApellidoPaterno, "");
        }

        private void txtApellidoMaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoMaterno.Text.Trim() == "")
            {
                epApeMater.SetError(txtApellidoMaterno, "Debe ingresar el apellido materno");
            }
            else
                epApeMater.SetError(txtApellidoMaterno, "");
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

        private void txtSueldo_Validating(object sender, CancelEventArgs e)
        {
            if (txtSueldo.Text.Trim() == "")
            {
                epSueldo.SetError(txtSueldo, "Debe ingresar el sueldo");
            }
            else
                epSueldo.SetError(txtSueldo, "");
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefono.Text.Trim() == "")
            {
                epTelefono.SetError(txtTelefono, "Debe ingresar el teléfono");
            }
            else
                epTelefono.SetError(txtTelefono, "");
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                epUsername.SetError(txtUsername, "Debe ingresar el username");
            }
            else
                epUsername.SetError(txtUsername, "");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
            {
                epContraseña.SetError(txtPassword, "Debe ingresar la contraseña");
            }
            else
                epContraseña.SetError(txtPassword, "");
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCorreo.Text.Trim() == "")
            {
                epCorreo.SetError(txtCorreo, "Debe ingresar el correo");
            }
            else
                epCorreo.SetError(txtCorreo, "");
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
