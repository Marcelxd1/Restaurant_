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
    public partial class frm_Gestion_Productos : Form
    {
        private Form formularioActivo = null;
        public frm_Gestion_Productos()
        {
            InitializeComponent();
            abrirFormulario(new frm_Gestion_Productos_RegistroPlatos());
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
            panelContenedorProductos.Controls.Add(formularioMostrar);
            formularioMostrar.Show();
        }

        private void lblRegistrarPlato_MouseEnter(object sender, EventArgs e)
        {
            lblRegistrarPlato.ForeColor = Color.Blue;
        }

        private void lblRegistrarPlato_MouseLeave(object sender, EventArgs e)
        {
            lblRegistrarPlato.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void lblRegistrarCombo_MouseEnter(object sender, EventArgs e)
        {
            lblRegistrarCombo.ForeColor = Color.Blue;
        }

        private void lblRegistrarCombo_MouseLeave(object sender, EventArgs e)
        {
            lblRegistrarCombo.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void lblRegistrarCategoria_MouseLeave(object sender, EventArgs e)
        {
            lblRegistrarCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void lblRegistrarCategoria_MouseEnter(object sender, EventArgs e)
        {
            lblRegistrarCategoria.ForeColor = Color.Blue;
        }

        private void lblRegistrarPlato_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Productos_RegistroPlatos());
        }

        private void lblRegistrarCombo_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Productos_RegistroCombo());
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Productos_RegistroCombo());
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Productos_RegistroCombo());
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Productos_RegistroCategoria());
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Productos_RegistroCategoria());
        }

        private void lblRegistrarCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion_Productos_RegistroCategoria());
        }
    }
}
