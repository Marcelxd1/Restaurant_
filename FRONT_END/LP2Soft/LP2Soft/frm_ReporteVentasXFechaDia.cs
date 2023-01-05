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

        private async void btnGeneraReporte_Click(object sender, EventArgs e)
        {
            frm_Loading form_loading = new frm_Loading();
            form_loading.Show();
            Task hilo1 = new Task(generar);
            hilo1.Start();
            await hilo1;
            form_loading.Hide();
            visorPDF.LoadFile("temporal.pdf");
            visorPDF.setShowToolbar(true);
        }

        private void generar()
        {
            archivoBytes = daoReporte.generarReporteVentasXDiaFecha();
            File.WriteAllBytes("temporal.pdf", archivoBytes);
        }
    }
}
