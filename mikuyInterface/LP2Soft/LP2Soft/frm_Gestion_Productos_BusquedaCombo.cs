using LP2Soft.NegocioWS;
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
    public partial class frm_Gestion_Productos_BusquedaCombo : Form
    {
        private NegocioWS.promocion _promoSeleccionada ; 
        private NegocioWS.NegocioWSClient daoNegocio;
        public frm_Gestion_Productos_BusquedaCombo()
        {
            InitializeComponent();
            PromoSeleccionada = new NegocioWS.promocion();
            daoNegocio = new NegocioWS.NegocioWSClient();
            dgvCombos.DataSource=daoNegocio.listarTodasPromociones();
        }

        public promocion PromoSeleccionada { get => _promoSeleccionada; set => _promoSeleccionada = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            PromoSeleccionada = (NegocioWS.promocion)dgvCombos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
