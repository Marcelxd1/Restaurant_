using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
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
        private frm_Mesero_MesaVer2 formMesero1;
        private int botonActivo ;
        private bool flag = false;
        private bool gestion = false;
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
                btnAsistencia.Visible = true;
                btnAsistencia.Location = new System.Drawing.Point(23, 142);
                btnCaja.Visible = false;
                btnClientes.Visible = false;
                btnGestion.Visible = false;
                btnCocina.Visible = false;

            }
            else if (rol.descripcion == "CAJERO")
            {
                btnGestion.Visible = false;
                //btnCocina.Location = new System.Drawing.Point(23, 142);
                btnCaja.Location = new System.Drawing.Point(23, 142);
                btnAsistencia.Location = new System.Drawing.Point(23, 193);
                //btnClientes.Location = new System.Drawing.Point(23, 293);
                btnClientes.Visible = false;
            }
            else if (rol.descripcion == "COCINERO")
            {
                btnCocina.Visible = true;
                btnAsistencia.Visible = true;
                btnCocina.Location = new System.Drawing.Point(23, 91);
                btnAsistencia.Location = new System.Drawing.Point(23, 142);
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
            btnProductos.FillColor = Color.Transparent;
            btnGasto.FillColor = Color.Transparent;
            btnMesa.FillColor = Color.Transparent;
            btnClient.FillColor = Color.Transparent;
            btnEmpleados.FillColor = Color.Transparent;
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


        private async void btnPedidos_Click(object sender, EventArgs e)
        {
            restablecerBotones();
            frm_Loading frm_Loading = new frm_Loading();
            frm_Loading.Show();
            btnPedidos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            Task hilo1 = new Task(InicializarForm);
            hilo1.Start();
            await hilo1;
            frm_Loading.Hide(); 
            if (rol.descripcion == "MESERO")
            {
                abrirFormulario(formMesero1);
            }
            else
                abrirFormulario(new frm_Cajero_Pedidos(persona, rol));

        }

        private void InicializarForm()
        {
            if (rol.descripcion == "MESERO")
                formMesero1 = new frm_Mesero_MesaVer2(persona, rol);
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            if (gestion == false)
            {
                panelGestion.Height = 260;
                gestion = true;
                this.panelGestion.BackgroundImage = global::LP2Soft.Properties.Resources.fonii;
            }
            else
            {
                panelGestion.Height = 39;
                this.panelGestion.BackgroundImage = global::LP2Soft.Properties.Resources.fondo2;
                gestion = false;
            }
            //restablecerBotones();
            //btnGestion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            //abrirFormulario(new frm_Gestion());
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            restablecerBotones();
            btnAsistencia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            abrirFormulario(new frm_Asitencia(this.persona));
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            restablecerBotones();
            btnClientes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            abrirFormulario(new frm_Gestion_Reportes());
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

        

        private void btnPedidos_MouseMove(object sender, MouseEventArgs e)
        {
            PanelMenu.Width = 185;
            btnSignOut.Width = 185;
        }

        private void btnPedidos_MouseLeave(object sender, EventArgs e)
        {
            PanelMenu.Width = 58;
            btnSignOut.Width = 58;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(flag == false)
            {
                PanelMenu.Width = 185;
                btnSignOut.Width = 185;
                flag = true;
            }
            else
            {
                PanelMenu.Width = 58;
                btnSignOut.Width = 58;
                flag = false;
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            restablecerBotones();
            btnProductos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            abrirFormulario(new frm_Gestion_Productos());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            restablecerBotones();
            btnEmpleados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            abrirFormulario(new frm_Gestion_Usuario_Listar());
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            restablecerBotones();
            btnClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            abrirFormulario(new frm_Clientes_Listar());
        }

        private void btnMesa_Click(object sender, EventArgs e)
        {
            restablecerBotones();
            btnMesa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            abrirFormulario(new frm_Gestion_Mesas());
        }

        private void btnGasto_Click(object sender, EventArgs e)
        {
            restablecerBotones();
            btnGasto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            abrirFormulario(new frm_Gestion_Gastos());
        }
    }
}
