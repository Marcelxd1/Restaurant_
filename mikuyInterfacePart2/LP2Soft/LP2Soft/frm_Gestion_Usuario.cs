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
        public frm_Gestion_Usuario()
        {
            InitializeComponent();
            daoUser = new UserWS.UserWSClient();    
            _usuario = new UserWS.usuario();
            cmbRol.DataSource = daoUser.listarRolTodos();
            cmbRol.DisplayMember = "descripcion";
            cmbRol.ValueMember = "id_rol";
            cmbRol.SelectedIndex = -1; 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_Gestion_Usuario_Load(object sender, EventArgs e)
        {

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
            _usuario.apellido_materno = txtApellidoMaterno.Text.Trim();
            _usuario.apellido_paterno = txtApellidoPaterno.Text.Trim();
            _usuario.DNI   = txtDNI.Text.Trim();
            _usuario.nombre = txtNombre.Text.Trim();
            _usuario.rol = (UserWS.rol)cmbRol.SelectedItem;
            _usuario.salario = Double.Parse(txtSueldo.Text.Trim());
            _usuario.telefono = txtTelefono.Text.Trim();
            _usuario.usuario1 = txtUsername.Text.Trim();
            _usuario.password = pass1; 
            _usuario.correo = txtCorreo.Text.Trim();
            int resultado = daoUser.insertarUsuario(_usuario);
            if(resultado > 0)
            {
                MessageBox.Show("Se ha registrado correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApellidoMaterno.Text = "";
                txtApellidoPaterno.Text = "";
                txtDNI.Text = "";
                txtNombre.Text = "";
                txtPassword.Text = "";
                txtPasswordConfirm.Text = "";
                txtSueldo.Text = "";
                txtTelefono.Text = "";
                txtUsername.Text = "";
                txtCorreo.Text = "";
                pbFoto.Image = null;
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
