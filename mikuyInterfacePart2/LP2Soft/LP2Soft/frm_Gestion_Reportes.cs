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
    }
}
