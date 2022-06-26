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
    public partial class frm_ReporteVentasXFechaDia : Form
    {
        private ReporteWS.ReporteWSClient daoReporte;
        private byte[] archivoBytes = null;
        public frm_ReporteVentasXFechaDia()
        {
            InitializeComponent();
            daoReporte = new ReporteWS.ReporteWSClient();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            archivoBytes = daoReporte.generarReporteVentasXDiaFecha();
            File.WriteAllBytes("temporal.pdf", archivoBytes);
            visorPDF.LoadFile("temporal.pdf");
            visorPDF.setShowToolbar(true);
        }
    }
}
