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
    public partial class frm_Login_Usuario : Form
    {
        private UserWS.UserWSClient daoUser;
        
        public frm_Login_Usuario()
        {
            InitializeComponent();
            daoUser = new UserWS.UserWSClient();
            lblError.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserWS.usuario user = new UserWS.usuario();
            user.usuario1 = txtUsuario.Text;
            user.password = txtPassword.Text;

            UserWS.usuario userVerificar = new UserWS.usuario();
            userVerificar = daoUser.verificarCuentaUsuario(user);
            if (userVerificar != null)
            {
                //lblError.Visible = true;
                //lblError.Text = "ENTRO ACA.";
                UserWS.rol rol = daoUser.buscarRolPorId(userVerificar.rol.id_rol);
                UserWS.persona persona = daoUser.buscarPersonaPorIdUsuario(userVerificar.id_usuario);

                Main formPrincipal = new Main(persona, rol);
                this.Hide();
                formPrincipal.Show();
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "La cuenta de usuario o contraseña no es correcta!";
            }
        }
    }
}
