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
    public partial class frm_Login_Recuperar_Contrasenia : Form
    {
        private UserWS.UserWSClient daoUser;
        int id_persona;
        public frm_Login_Recuperar_Contrasenia()
        {
            InitializeComponent();
            daoUser = new UserWS.UserWSClient();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            int dni = Int32.Parse(txtDNI.Text);
            string apellidoPaterno = txtApellidoPaterno.Text;

            id_persona = daoUser.verificarUsuario(dni, apellidoPaterno);
            if (id_persona > 0)
            {
                txtContraseniaNueva.Visible = true;
                lblNuevaPass.Visible = true;
                btnCambiarContrasenia.Visible = true;   
            }
            else
            {
                lblMsjError.Visible = true;
                lblMsjError.Text = "NO SE HA ENCONTRADO A NINGUN USUARIO \n CON LOS DATOS INGRESADOS";
                txtDNI.Text = "";
                txtApellidoPaterno.Text = "";
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnCambiarContrasenia_Click(object sender, EventArgs e)
        {
            if (txtContraseniaNueva.Text== "")
            {
                MessageBox.Show("INGRESE UNA CONTRASEÑA NUEVA", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String password = txtContraseniaNueva.Text;
            int resultado = daoUser.cambiarContrasenia(id_persona , password);
            if (resultado != 0)
            {
                MessageBox.Show("SE HA CAMBIADO LA CONTRASEÑA CORRECTAMENTE", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
