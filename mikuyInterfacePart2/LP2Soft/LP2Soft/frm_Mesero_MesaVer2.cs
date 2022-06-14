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
        public frm_Mesero_MesaVer2()
        {
            InitializeComponent();
            daonegocio = new NegocioWS.NegocioWSClient();
            //no se sabe si elimino los botones anteriores o no 
            cargarBotonones();
            
            btnFalso.Visible = false;
            btnFalso.Enabled =false;
        }
        
        public void cargarBotonones()
        {
            int top = 150;
            int left = 100;
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
                button.Left = left;
                button.Top = top;
                button.Text = "Mesa_" + (i + 1).ToString();
                button.Name = "btn_" + i.ToString();
                //button.Click += guna2Button1_Click;
                button.Click += new System.EventHandler(hacerCLik);
                
                this.Controls.Add(button);
                top += button.Height + 2;
                if (top == 275)
                {
                    top = 150;
                    left += button.Width + 5;
                }

                if (lista_mesas[i].disponible == true)
                    button.BackColor = Color.Aquamarine;
                else
                    button.BackColor = Color.IndianRed;

                lista_botones.Add(button);

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
                //polimorfismo cajero mesero 
                //formularios
            }

            else
            {
                mesaSelec.disponible = true;
                lista_botones.ElementAt(indice).BackColor = Color.Aquamarine;
            }

            daonegocio.modificarMesa(mesaSelec);
            ///cambiar estado a ocupado 
            ///a disponible
            ///cambiar la Bd en ambos casos
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            //obtener el indice
            char[] sep = new char[] { '_' };
            string[] subs = sender.ToString().Split(sep, StringSplitOptions.RemoveEmptyEntries);
            //tendra btn y i
            int indice = Int32.Parse(subs[1])-1;
            //obtener el objeto mesa
            NegocioWS.mesa mesaSelec=lista_mesas.ElementAt(indice);
            if (mesaSelec.disponible == true)
            {
                mesaSelec.disponible = false;
                lista_botones.ElementAt(indice).BackColor = Color.IndianRed;
            }

            else
            {
                mesaSelec.disponible = true;
                lista_botones.ElementAt(indice).BackColor = Color.GreenYellow;
            }
                
            daonegocio.modificarMesa(mesaSelec);
            ///cambiar estado a ocupado 
            ///a disponible
            ///cambiar la Bd en ambos casos
        }

        
    }
}
