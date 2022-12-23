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
    public partial class frm_Asitencia : Form
    {

        private UserWS.UserWSClient daoUser;
        public frm_Asitencia()
        {
            InitializeComponent();
            daoUser = new UserWS.UserWSClient();
        }


        public void limpiarComponentes()
        {
            txtPassword.Text = "";
            txtUsuario.Text = "";
        }
        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
            
            
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private bool verificarDatos()
        {

            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una contraseña", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

            private void btnAsistencia_Click(object sender, EventArgs e)
        {
            UserWS.usuario user = new UserWS.usuario();
            if (verificarDatos())
            {
                user.usuario1 = txtUsuario.Text;
                user.password = txtPassword.Text;
                UserWS.usuario userVerificar = new UserWS.usuario();
                userVerificar = daoUser.verificarCuentaUsuario(user);
                if (userVerificar != null)
                {
                    int resultado = daoUser.asistenciaEntrada(userVerificar.id_usuario);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha registrado entrada correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cuenta o contraseña incorrecta", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                limpiarComponentes();
            }
            else
                return;
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            UserWS.usuario user = new UserWS.usuario();
            if (verificarDatos())
            {
                user.usuario1 = txtUsuario.Text;
                user.password = txtPassword.Text;
                UserWS.usuario userVerificar = new UserWS.usuario();
                userVerificar = daoUser.verificarCuentaUsuario(user);
                if (userVerificar != null)
                {
                    int resultado = daoUser.asistenciaSalida(userVerificar.id_usuario);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha registrado salida correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cuenta o contraseña incorrecta", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                limpiarComponentes();
            }
            else
                return;
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
