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
    public partial class frm_ReporteCaja : Form
    {
        private ReporteWS.ReporteWSClient daoReporte;
        private byte[] archivoBytes = null;
        string fechaini_str = "", fechafin_str = "";
        DateTime ini = DateTime.Now.AddMonths(-1), fin = DateTime.Now;
        public frm_ReporteCaja()
        {
            InitializeComponent();
            daoReporte = new ReporteWS.ReporteWSClient();
            dtpIni = null; dtpFin = null;
        }

        private async void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            frm_Loading form_loading = new frm_Loading();
            form_loading.Show();
            if (dtpIni != null && dtpFin != null)
            {
                fechaini_str = dtpIni.Value.ToString("yyyy-MM-dd");
                fechafin_str = dtpFin.Value.ToString("yyyy-MM-dd");
            }
            else if(dtpIni != null)
            {
                fechaini_str = dtpIni.Value.ToString("yyyy-MM-dd");
                fechafin_str = fin.ToString("yyyy-MM-dd");
            }
            else if(dtpIni == null && dtpFin == null)
            {
                fechaini_str = ini.ToString("yyyy-MM-dd");
                fechafin_str = fin.ToString("yyyy-MM-dd");
            }
            Task hilo1 = new Task(generar);
            hilo1.Start();
            await hilo1;
            form_loading.Hide();

            visorPDF.LoadFile("temporal.pdf");
            visorPDF.setShowToolbar(true);
        }

        private void generar()
        {
            archivoBytes = daoReporte.generarReporteCajaxFecha(fechaini_str, fechafin_str);
            File.WriteAllBytes("temporal.pdf", archivoBytes);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
