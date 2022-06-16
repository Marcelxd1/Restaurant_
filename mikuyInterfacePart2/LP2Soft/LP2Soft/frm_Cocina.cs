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
    public partial class frm_Cocina : Form
    {
        private CajaWS.CajaWSClient daoCaja;
        public frm_Cocina()
        {
            InitializeComponent();
            daoCaja = new CajaWS.CajaWSClient();
            panelContenedor.Controls.Clear();
            CajaWS.pedido[] pedidos  = daoCaja.listarPedidosPendientes();
            if (pedidos!= null)
            {
                BindingList<CajaWS.pedido> pedidosBL = new BindingList<CajaWS.pedido>(pedidos);
                lblNotificacion.Visible = false;
                foreach(CajaWS.pedido pedido in pedidosBL)
                {
                    frm_Cocina_DatosMesa formCocinaDatosMesa = new frm_Cocina_DatosMesa(pedido);
                    formCocinaDatosMesa.Dock = DockStyle.Left;
                    formCocinaDatosMesa.TopLevel = false;
                    panelContenedor.Controls.Add(formCocinaDatosMesa);
                    formCocinaDatosMesa.Visible = true;
                }
            }
            else
            {
                lblNotificacion.Visible = true;
                lblNotificacion.Text = "TODOS LOS PEDIDOS HAN SIDO ATENDIDOS !";
                panelContenedor.Controls.Add(lblNotificacion);
                
            }

            
        }

    }
}
