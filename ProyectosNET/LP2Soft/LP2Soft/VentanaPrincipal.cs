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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            UC_Mesero_Mesa prueba = new UC_Mesero_Mesa();
            addUserControl(prueba);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void  addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            guna2Panel7.Controls.Clear();
            guna2Panel7.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Mesero_Mesa prueba = new UC_Mesero_Mesa();
            addUserControl(prueba);
            
                    
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Gestion prueba = new UC_Gestion();
            addUserControl(prueba);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
