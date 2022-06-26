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
    public partial class frm_Cocina_DatosMesa : Form
    {
        private CajaWS.CajaWSClient daoCaja;
        private int idPedidoActualizado ;
        
        
        public frm_Cocina_DatosMesa()
        {
            InitializeComponent();
            daoCaja = new CajaWS.CajaWSClient();    
        }
        public frm_Cocina_DatosMesa(CajaWS.pedido pedido)
        {
            InitializeComponent();
            daoCaja = new CajaWS.CajaWSClient();
            CajaWS.lineaPedido[] lineas = daoCaja.listarLineaPedidoMesa(pedido.idPedido);
            if (pedido.mesa.idMesa == 3)
            {
                lblMesa.Text = "Para llevar";
            }
            else
                lblMesa.Text = "Mesa " + pedido.mesa.numMesa;
            lblIdPedido.Text = pedido.idPedido.ToString();
            panelPedidos.Controls.Clear();
            if (pedido.estado == 'E') // NO ATENDIDO
            {
                pcbEstado.Image = global::LP2Soft.Properties.Resources.PRIORIDAD;
            }
            else if(pedido.estado == 'P') // EN PROCESO
            {
                pcbEstado.Image = global::LP2Soft.Properties.Resources.icon_espera;
            }
            else if (pedido.estado == 'L')
            {
                pcbEstado.Image = global::LP2Soft.Properties.Resources.Check;
            }
            if (lineas != null)
            {
                BindingList<CajaWS.lineaPedido> lineaBL = new BindingList<CajaWS.lineaPedido>(lineas);
                foreach(CajaWS.lineaPedido linea in lineaBL)
                {
                    frm_Cocina_DatosPedido formDatosPedido = new frm_Cocina_DatosPedido(linea);
                    formDatosPedido.Dock = DockStyle.Top;
                    formDatosPedido.TopLevel = false;
                    panelPedidos.Controls.Add(formDatosPedido);
                    formDatosPedido.Visible = true;
                    
                }
            }
        }

        private void btnPreparado_Click(object sender, EventArgs e)
        {
            int idPedido = Int32.Parse(lblIdPedido.Text);
            int resultado;
            resultado = daoCaja.modificarEstadoPedido(idPedido, 'P');
            if (resultado != 0)
            {
                pcbEstado.Image = global::LP2Soft.Properties.Resources.icon_espera;
            }
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            int idPedido = Int32.Parse(lblIdPedido.Text);
            int resultado;
            resultado = daoCaja.modificarEstadoPedido(idPedido, 'L');
            if (resultado != 0)
            {
                pcbEstado.Image = global::LP2Soft.Properties.Resources.Check;
            }
        }

        
    }
}
