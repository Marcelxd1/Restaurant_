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
    public partial class frm_Gestion_Usuario_Listar : Form
    {
        private Form formularioActivo = null;
        public frm_Gestion_Usuario_Listar()
        {
            InitializeComponent();
        }
        public void abrirFormulario(Form formularioMostrar)
        {

        }

        private void txtBoxBuscar_MouseLeave(object sender, EventArgs e)
        {
            if(txtBoxBuscar.Text == "")
            {
                txtBoxBuscar.Text = "Buscar";
                txtBoxBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBoxBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxBuscar.Text == "Buscar")
            {
                txtBoxBuscar.Text = "";
                txtBoxBuscar.ForeColor = Color.Black;
            }
        }


    }
}
