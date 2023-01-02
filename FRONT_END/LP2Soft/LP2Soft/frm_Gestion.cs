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
    public partial class frm_Gestion : Form
    {
        public frm_Gestion()
        {
            InitializeComponent();
        }

        private void lblGestionUsuario_MouseEnter(object sender, EventArgs e)
        {
            lblGestionUsuario.ForeColor = Color.Blue;
        }

        private void imgGestionUsuario_MouseLeave(object sender, EventArgs e)
        {
            lblGestionUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void guna2ImageButton2_MouseEnter(object sender, EventArgs e)
        {
            lblReporte.ForeColor = Color.Blue;
        }

        private void guna2ImageButton2_MouseLeave(object sender, EventArgs e)
        {
            lblReporte.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void guna2ImageButton4_MouseEnter(object sender, EventArgs e)
        {
            lblGestionProd.ForeColor = Color.Blue;
        }

        private void guna2ImageButton4_MouseLeave(object sender, EventArgs e)
        {
            lblGestionProd.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void guna2ImageButton6_MouseEnter(object sender, EventArgs e)
        {
            lblGestionGastos.ForeColor = Color.Blue;
        }

        private void guna2ImageButton6_MouseLeave(object sender, EventArgs e)
        {
            lblGestionGastos.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void guna2ImageButton5_MouseEnter(object sender, EventArgs e)
        {
            lblGestionMesas.ForeColor = Color.Blue;
        }

        private void guna2ImageButton5_MouseLeave(object sender, EventArgs e)
        {
            lblGestionMesas.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void lblGestionUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pctBGestionUsuario_Click(object sender, EventArgs e)
        {

        }

        private void imgGestionUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblGestionProd_Click(object sender, EventArgs e)
        {
            frm_Gestion_Productos formGestionProducto = new frm_Gestion_Productos();
            formGestionProducto.ShowDialog();
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void lblGestionGastos_Click(object sender, EventArgs e)
        {
            frm_Gestion_Gastos formGestionGasto = new frm_Gestion_Gastos();
            formGestionGasto.ShowDialog();
        }

        private void lblGestionMesas_Click(object sender, EventArgs e)
        {
            frm_Gestion_Mesas formGestionMesas = new frm_Gestion_Mesas();
            formGestionMesas.ShowDialog();
        }

        private void lblReporte_Click(object sender, EventArgs e)
        {
            frm_Gestion_Reportes formReportes = new frm_Gestion_Reportes();
            formReportes.ShowDialog();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
