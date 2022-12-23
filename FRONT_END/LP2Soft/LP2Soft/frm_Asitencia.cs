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
        private UserWS.persona persona;
        public frm_Asitencia(UserWS.persona persona1)
        {
            InitializeComponent();
            daoUser = new UserWS.UserWSClient();
            dgvAsistencias.AutoGenerateColumns = false;
            persona = persona1;
            dgvAsistencias.DataSource = daoUser.listarAsistenciasUsuario(persona.id_persona);
            
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
                        MessageBox.Show("Se ha registrado su entrada correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cuenta o contraseña incorrecta", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                limpiarComponentes();
                dgvAsistencias.DataSource = daoUser.listarAsistenciasUsuario(persona.id_persona);
                dgvAsistencias.Refresh();   
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
                        MessageBox.Show("Se ha registrado su salida correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cuenta o contraseña incorrecta", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                limpiarComponentes();
                dgvAsistencias.DataSource = daoUser.listarAsistenciasUsuario(persona.id_persona);
                dgvAsistencias.Refresh();
            }
            else
                return;
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dgvAsistencias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            UserWS.asistencia asis = (UserWS.asistencia)dgvAsistencias.Rows[e.RowIndex].DataBoundItem;
            dgvAsistencias.Rows[e.RowIndex].Cells[0].Value = asis.fecha.ToString("dd-MM-yyyy");
            dgvAsistencias.Rows[e.RowIndex].Cells[1].Value = asis.hora_inicio.ToString("hh:mm:ss tt");
            if(asis.hora_finSpecified == true)
                dgvAsistencias.Rows[e.RowIndex].Cells[2].Value = asis.hora_fin.ToString("hh:mm:ss tt");
            
        }

    }
}
