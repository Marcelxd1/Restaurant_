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
    public partial class frm_Reporte_Asistencia : Form
    {
        private ReporteWS.ReporteWSClient daoReporte ;
        private byte[] archivoBytes;
        public frm_Reporte_Asistencia()
        {
            InitializeComponent();
            daoReporte = new ReporteWS.ReporteWSClient();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            //debe de tener este formato
            string fechaini_str = dtpFechaIni.Value.ToString("yyyy-MM-dd");
            string fechafin_str = dtpFechaFin.Value.ToString("yyyy-MM-dd");
            archivoBytes = daoReporte.generarReporteAsistencia(fechaini_str,fechafin_str);
            File.WriteAllBytes("temporal.pdf",archivoBytes);
            visorPDF.LoadFile("temporal.pdf");
            visorPDF.setShowToolbar(true);
        }
    }
}
