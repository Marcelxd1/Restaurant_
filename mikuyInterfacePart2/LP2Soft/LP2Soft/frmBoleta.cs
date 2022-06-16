using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class frmBoleta : Form
    {
        private byte[] arreglo;
        private ReporteWS.ReporteWSClient reporte;
        public frmBoleta(int IdPedido)
        {
            InitializeComponent();
            reporte = new ReporteWS.ReporteWSClient();  
            arreglo = reporte.generarBoletaVenta(IdPedido);
            File.WriteAllBytes("temporal.pdf", arreglo);
            visorPDF.LoadFile("temporal.pdf");
        }
    }
}
