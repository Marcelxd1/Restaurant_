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
    public partial class frm_Gestion_Reportes : Form
    {
        public frm_Gestion_Reportes()
        {
            InitializeComponent();
        }

        private void lblPlatoMasVendidos_Click(object sender, EventArgs e)
        {
            frm_Reporte_PlatosMasVendidos formMasVendidos = new frm_Reporte_PlatosMasVendidos();
            formMasVendidos.ShowDialog();
        }

        private void lblAsistencia_Click(object sender, EventArgs e)
        {
            frm_Reporte_Asistencia formAsitencia = new frm_Reporte_Asistencia();
            formAsitencia.ShowDialog();
        }

        private void guna2ImageButton2_MouseEnter(object sender, EventArgs e)
        {
            lblPlatoMasVendidos.ForeColor = Color.Blue;
        }

        private void guna2ImageButton2_MouseLeave(object sender, EventArgs e)
        {
            lblPlatoMasVendidos.ForeColor= System.Drawing.SystemColors.ControlText;
        }

        private void guna2ImageButton1_MouseEnter(object sender, EventArgs e)
        {
            lblAsistencia.ForeColor = Color.Blue;
        }

        private void guna2ImageButton1_MouseLeave(object sender, EventArgs e)
        {
            lblAsistencia.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void guna2ImageButton3_MouseEnter(object sender, EventArgs e)
        {
            lblReporteCaja.ForeColor = Color.Blue;
        }

        private void guna2ImageButton3_MouseLeave(object sender, EventArgs e)
        {
            lblReporteCaja.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void guna2ImageButton4_MouseEnter(object sender, EventArgs e)
        {
            lblReportePedido.ForeColor = Color.Blue;
        }

        private void guna2ImageButton4_MouseLeave(object sender, EventArgs e)
        {
            lblReportePedido.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void guna2ImageButton5_MouseEnter(object sender, EventArgs e)
        {
            lblVentas.ForeColor = Color.Blue;
        }

        private void guna2ImageButton5_MouseLeave(object sender, EventArgs e)
        {
            lblVentas.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void lblVentas_Click(object sender, EventArgs e)
        {
            frm_ReporteVentasXFechaDia formReporteVentasXFechaDia = new frm_ReporteVentasXFechaDia();
            formReporteVentasXFechaDia.ShowDialog();
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void lblReporteCaja_Click(object sender, EventArgs e)
        {
            frm_ReporteCaja form = new frm_ReporteCaja();
            form.ShowDialog();
        }

        private void btnReporteCaja_Click(object sender, EventArgs e)
        {
            frm_ReporteCaja form = new frm_ReporteCaja();
            form.ShowDialog();
        }

        private void lblReportePedido_Click(object sender, EventArgs e)
        {
            frm_ReportePedido form = new frm_ReportePedido();
            form.ShowDialog();
        }

        private void btnReportePedido_Click(object sender, EventArgs e)
        {
            frm_ReportePedido form = new frm_ReportePedido();
            form.ShowDialog();
        }
    }
}
