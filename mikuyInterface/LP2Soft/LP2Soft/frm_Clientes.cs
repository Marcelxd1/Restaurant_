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
    public partial class frm_Clientes : Form
    {
        public frm_Clientes()
        {
            InitializeComponent();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            frm_Clientes_Listar formClientesListar = new frm_Clientes_Listar();
            formClientesListar.ShowDialog();
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            frm_Clientes_Listar formClientesListar = new frm_Clientes_Listar();
            formClientesListar.ShowDialog();
        }

        private void lblListarUsuarios_Click(object sender, EventArgs e)
        {
            frm_Clientes_Listar formClientesListar = new frm_Clientes_Listar();
            formClientesListar.ShowDialog();
        }

        private void lblCrearUsuario_Click(object sender, EventArgs e)
        {
            frm_Clientes_Registrar formClientesRegistrar = new frm_Clientes_Registrar();
            formClientesRegistrar.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            frm_Clientes_Registrar formClientesRegistrar = new frm_Clientes_Registrar();
            formClientesRegistrar.ShowDialog();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            frm_Clientes_Registrar formClientesRegistrar = new frm_Clientes_Registrar();
            formClientesRegistrar.ShowDialog();
        }
    }
}
