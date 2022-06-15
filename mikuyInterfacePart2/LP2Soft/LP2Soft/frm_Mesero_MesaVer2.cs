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
    public partial class frm_Mesero_MesaVer2 : Form
    {
        private NegocioWS.NegocioWSClient daonegocio;
        private BindingList<NegocioWS.mesa> lista_mesas;
        private BindingList<Button> lista_botones;
        private Form formularioActivo = null;
        private UserWS.persona persona;
        private UserWS.rol rol;
        public frm_Mesero_MesaVer2(UserWS.persona persona, UserWS.rol rol)
        {
            InitializeComponent();
            this.persona = persona;
            this.rol = rol;
            daonegocio = new NegocioWS.NegocioWSClient();
            //no se sabe si elimino los botones anteriores o no 
            cargarBotonones();
            panelMesas.AutoScroll = true;
            
            
        }
        public void abrirFormulario(Form formularioMostrar)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = formularioMostrar;
            //formularioMostrar.TopLevel = false;
            formularioMostrar.Show();
        }
        public void cargarBotonones()
        {
            int top = 0;
            int left = 0;
            lista_mesas = new BindingList<NegocioWS.mesa>();
            foreach (NegocioWS.mesa item in daonegocio.listarTodasMesa())
            {
                if (item.estado == true)
                    lista_mesas.Add(item);
            }
            int limite = lista_mesas.Count();
            lista_botones = new BindingList<Button>();
            for (int i = 0; i < limite; i++)
            {
                Button button = new Button();
                button.Size = new Size(150, 90);
                button.Left = left;
                button.Top = top;
                button.Text = "Mesa_" + (i + 1).ToString();
                button.Name = "btn_" + i.ToString();
                //button.Image = Properties.Resources.mesaIcono;
                
                button.Click += new System.EventHandler(hacerCLik);
                
                this.Controls.Add(button);
                left += button.Width+2;
                if(left >= 470)
                {
                    left = 0;
                    top+= button.Height +2;
                }
                //top += button.Height + 2;
                //if (top >= 400)
                //{
                //    top = 0;
                //    left += button.Width + 5;
                    
                //    if(left >= 800)
                //    {
                //        left = 0;
                //        top+= button.Height + 2;

                //    }
                    
                //}
                
                if (lista_mesas[i].disponible == true)
                    button.BackColor = Color.Aquamarine;
                else
                    button.BackColor = Color.IndianRed;

                lista_botones.Add(button);
                panelMesas.Controls.Add((Control)button);
            }
            
        }
        private void hacerCLik(object sender, EventArgs e)
        {
            //obtener el indice
            char[] sep = new char[] { '_' };
            string[] subs = sender.ToString().Split(sep, StringSplitOptions.RemoveEmptyEntries);
            //tendra btn y i
            int indice = Int32.Parse(subs[1]) - 1;
            //obtener el objeto mesa
            NegocioWS.mesa mesaSelec = lista_mesas.ElementAt(indice);
            if (mesaSelec.disponible == true)
            {
                mesaSelec.disponible = false;
                lista_botones.ElementAt(indice).BackColor = Color.IndianRed;
                abrirFormulario(new frm_Caja_Pedido_Pedir());
                //Abran formularios aqui
                //if (rol.descripcion == "MESERO")
                //{
                //    //FORMULARIO DE MESERO
                //    //abrirFormulario()
                //}
                //else if(rol.descripcion == "CAJERO")
                //{
                //    //FORMULARIO DE CAJERO
                //    //abrirFormulario();
                //}
                
            }

            else
            {
                mesaSelec.disponible = true;
                lista_botones.ElementAt(indice).BackColor = Color.Aquamarine;
            }

            daonegocio.modificarMesa(mesaSelec);
            
        }
        
    }
}
