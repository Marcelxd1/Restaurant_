using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class frm_Login_Usuario : Form
    {
        private UserWS.UserWSClient daoUser;
        private UserWS.rol rol ;
        private UserWS.persona persona;
        private UserWS.usuario userVerificar;
        public frm_Login_Usuario()
        {
            InitializeComponent();
            daoUser = new UserWS.UserWSClient();
            lblError.Visible = false;
        }


        private void label4_Click(object sender, EventArgs e)
        {
            frm_Login_Recuperar_Contrasenia formRecuperarContrasenia = new frm_Login_Recuperar_Contrasenia();
            formRecuperarContrasenia.ShowDialog();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLoginUsuario_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una constraseña", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frm_Loading form_loading = new frm_Loading();
            form_loading.Show();
            Task hilo1 = new Task(cargaAparte);
            hilo1.Start();
            await hilo1;
            form_loading.Hide();
            if (userVerificar != null)
            {

                this.Hide();
                Main formPrincipal = new Main(persona, rol, userVerificar);
                formPrincipal.Show();

            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "La cuenta de usuario o contraseña no es correcta!";
            }
        }

        private void cargaAparte()
        {
            UserWS.usuario user = new UserWS.usuario();
            user.usuario1 = txtUsuario.Text;
            user.password = txtPassword.Text;

            userVerificar = new UserWS.usuario();
            //frm_Load cargando = new frm_Load();
            userVerificar = daoUser.verificarCuentaUsuario(user);
            //cargando.ShowDialog();
            if (userVerificar != null)
            {
                //lblError.Visible = true;
                //lblError.Text = "ENTRO ACA.";
                rol = daoUser.buscarRolPorId(userVerificar.rol.id_rol);
                persona = daoUser.buscarPersonaPorIdUsuario(userVerificar.id_usuario);

            }

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

   
    }
}
