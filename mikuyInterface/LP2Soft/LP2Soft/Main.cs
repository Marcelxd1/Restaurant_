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
    public partial class Main : Form
    {
        private Form formularioActivo = null; 
        public Main()
        {
            InitializeComponent();
        }

        public void abrirFormulario(Form formularioMostrar)
        {
            if (formularioActivo != null)
                formularioActivo.Close(); 
            formularioActivo = formularioMostrar;
            formularioMostrar.TopLevel = false;
            panelContenedor.Controls.Add(formularioMostrar);
            formularioMostrar.Show();   
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Mesero_Mesa());

        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Gestion());
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Asitencia());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_Clientes());
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
