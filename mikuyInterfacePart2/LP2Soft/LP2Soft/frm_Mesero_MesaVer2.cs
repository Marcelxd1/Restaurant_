using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        private bool flag = false;
        public frm_Mesero_MesaVer2(UserWS.persona persona, UserWS.rol rol)
        {
            InitializeComponent();
            this.persona = persona;
            this.rol = rol;
            daonegocio = new NegocioWS.NegocioWSClient();
            cargarBotonones();
            panelMesas.AutoScroll = true;
            label1.Enabled = false;
            label1.Visible = false;
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
                int k = 1;
                lista_mesas = new BindingList<NegocioWS.mesa>();
                foreach (NegocioWS.mesa item in daonegocio.listarTodasMesa())
                {
                    if (item.estado == true)
                    {
                        item.numMesa = k;
                        lista_mesas.Add(item);
                        k++;
                    }

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
                    button.Image = Properties.Resources.mesaIcono;
                    button.TextImageRelation = TextImageRelation.ImageAboveText;
                    button.Click += new System.EventHandler(hacerCLik);
                    button.Font = new Font(label1.Font, FontStyle.Bold);
                    button.ForeColor = Color.White;
                    button.Cursor = Cursors.Hand;
                    this.Controls.Add(button);
                    left += button.Width + 2;
                    if (left >= 470)
                    {
                        left = 0;
                        top += button.Height + 2;
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
                        button.BackColor = Color.RoyalBlue;
                    else
                        button.BackColor = Color.IndianRed;
                    try
                    {
                        daonegocio.modificarMesa(lista_mesas[i]);
                        //para cargar el numero de mesa
                    }
                    catch (Exception)
                    {
                        throw;
                    }
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
            Estado estado;
            //obtener el objeto mesa
            NegocioWS.mesa mesaSelec = lista_mesas.ElementAt(indice);
            if (mesaSelec.disponible == true)
            {
                
                //abrirFormulario(new frm_Caja_Pedido_Pedir());
                //Abran formularios aqui

                if (rol.descripcion == "MESERO")
                {
                    estado = Estado.Inicial;
                    frm_Mesero_Mesa_Pedido forPedMes = new frm_Mesero_Mesa_Pedido(estado,mesaSelec.idMesa);
                    forPedMes.Mesa = mesaSelec;
                    forPedMes.Mesero = persona;
                    //forPedMes.iniciar();
                    if (forPedMes.ShowDialog() == DialogResult.OK)
                    {
                        if (forPedMes.Hecho == true)//solo si se realizó pedido
                        {
                            mesaSelec.disponible = false;
                            lista_botones.ElementAt(indice).BackColor = Color.IndianRed;
                        }

                    }

                }

            }
            else
            {
                estado = Estado.Modificar;
                frm_Mesero_Mesa_Pedido forPedMes = new frm_Mesero_Mesa_Pedido(estado, mesaSelec.idMesa);
                forPedMes.Mesa = mesaSelec;
                forPedMes.Mesero = persona;
                if (forPedMes.ShowDialog() == DialogResult.OK)
                {
                    if (forPedMes.Hecho == true)//solo si se realizó pedido
                    {
                        mesaSelec.disponible = true;
                        lista_botones.ElementAt(indice).BackColor = Color.RoyalBlue;
                    }

                }
            }

            daonegocio.modificarMesa(mesaSelec);
            
        }

       
    }
}
