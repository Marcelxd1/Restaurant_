using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class Main : Form
    {
        private UserWS.persona persona;
        private UserWS.rol rol;
        private Form formularioActivo = null;
        private Form cargando = new frm_Loading();
        private int botonActivo ; 
        public Main()
        {
            InitializeComponent();
        }
        public Main(UserWS.persona persona, UserWS.rol rol , UserWS.usuario user)
        {
            InitializeComponent();
            this.persona = persona;
            this.rol = rol;
            lblNombre.Text = this.persona.nombre + " " + this.persona.apellido_paterno;
            lblRolPersona.Text = this.rol.descripcion;
            if (user.imagen != null)
            {
                MemoryStream ms = new MemoryStream(user.imagen);
                pbPersona.Image = new Bitmap(ms);
            }
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
                btnCocina.Location = new System.Drawing.Point(23, 142);
                btnCaja.Location = new System.Drawing.Point(23, 193);
                btnAsistencia.Location = new System.Drawing.Point(23, 243);
                btnClientes.Location = new System.Drawing.Point(23, 293);
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
        public void restablecerBotones()
        {
            btnAsistencia.FillColor = Color.Transparent;
            btnCaja.FillColor = Color.Transparent;
            btnClientes.FillColor = Color.Transparent;
            btnCocina.FillColor = Color.Transparent;
            btnGestion.FillColor = Color.Transparent;
            btnPedidos.FillColor = Color.Transparent;
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
            restablecerBotones();
            btnPedidos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            if (rol.descripcion == "MESERO")
            {
                abrirFormulario(new frm_Mesero_MesaVer2(persona, rol));
            }
            else
                abrirFormulario(new frm_Cajero_Pedidos(persona, rol));

        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            restablecerBotones();
            btnGestion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            abrirFormulario(new frm_Gestion());
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            restablecerBotones();
            btnAsistencia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            abrirFormulario(new frm_Asitencia());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            restablecerBotones();
            btnClientes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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

        private  void btnCaja_Click(object sender, EventArgs e)
        {
            restablecerBotones();
            btnCaja.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            abrirFormulario(new frm_Caja());
        }

        private void btnCocina_Click(object sender, EventArgs e)
        {
            restablecerBotones();
            btnCocina.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            abrirFormulario(new frm_Cocina());
        }


        
    }
}
