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
    public partial class frm_Gestion_Usuario_Contenedor : Form
    {
        private Form formularioActivo = null; 
        public frm_Gestion_Usuario_Contenedor()
        {
            InitializeComponent();
            abrirFormulario(new frm_Gestion_Usuario_Listar());
        }
        public void abrirFormulario(Form formularioMostrar)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioMostrar;
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelGestionContenedor.Controls.Add(formularioMostrar);
            formularioMostrar.Show();
        }

        private void panelGestionContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Usuario_Listar());
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Usuario());
        }

        private void lblListarUsuarios_MouseEnter(object sender, EventArgs e)
        {
            lblListarUsuarios.ForeColor = Color.Blue;
        }

        private void lblListarUsuarios_MouseLeave(object sender, EventArgs e)
        {
            lblListarUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void lblCrearUsuario_MouseEnter(object sender, EventArgs e)
        {
            lblCrearUsuario.ForeColor = Color.Blue;
        }

        private void lblCrearUsuario_MouseLeave(object sender, EventArgs e)
        {
            lblCrearUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Usuario_Listar());
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Usuario_Listar());
        }

        private void lblListarUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Usuario_Listar());
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Usuario());
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Usuario());
        }

        private void lblCrearUsuario_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Usuario());
        }

        private void guna2ImageButton1_MouseEnter(object sender, EventArgs e)
        {
            lblCrearUsuario.ForeColor = Color.Blue;
            
        }

        private void guna2ImageButton1_MouseLeave(object sender, EventArgs e)
        {
            lblCrearUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void guna2ImageButton2_MouseEnter(object sender, EventArgs e)
        {
            lblListarUsuarios.ForeColor = Color.Blue;
        }

        private void guna2ImageButton2_MouseLeave(object sender, EventArgs e)
        {
            lblListarUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
        }
    }
}
