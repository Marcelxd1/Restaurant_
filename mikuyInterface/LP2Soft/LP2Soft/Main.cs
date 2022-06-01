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
        private UserWS.persona persona;
        private UserWS.rol rol;
        private Form formularioActivo = null; 
        public Main()
        {
            InitializeComponent();
        }
        public Main(UserWS.persona persona, UserWS.rol rol)
        {
            InitializeComponent();
            this.persona = persona;
            this.rol = rol;
            lblNombre.Text = this.persona.nombre + " " + this.persona.apellido_paterno;
            lblRolPersona.Text = this.rol.descripcion;
            if (rol.descripcion == "MESERO")
            {
                btnAsistencia.Visible = false;
                btnCaja.Visible = false;
                btnClientes.Visible = false;
                btnGestion.Visible = false;
                btnCocina.Visible = false;
            }
            else if (rol.descripcion == "CAJERO")
            {
                btnGestion.Visible = false;
            }
            else if (rol.descripcion == "COCINERO")
            {
                btnAsistencia.Visible = false;
                btnCaja.Visible = false;
                btnClientes.Visible = false;
                btnGestion.Visible = false;
                btnPedidos.Visible = false;
            }
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

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frm_Login_Usuario frmLogin = new frm_Login_Usuario();
            frmLogin.Show();
            this.Close();
        }
    }
}
