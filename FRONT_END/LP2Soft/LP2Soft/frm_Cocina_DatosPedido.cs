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
    public partial class frm_Cocina_DatosPedido : Form
    {
        public frm_Cocina_DatosPedido()
        {
            InitializeComponent();
        }
        public frm_Cocina_DatosPedido(CajaWS.lineaPedido linea)
        {
            InitializeComponent();
            lblPedido.Text = linea.unidades + "x" + linea.item.nombre;
        }
    }
}
