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
        private NegocioWS.promocion _promoSeleccionada;
        private NegocioWS.NegocioWSClient daoNegocio;
        public frm_Gestion_Productos_BusquedaCombo()
        {
            InitializeComponent();
            PromoSeleccionada = new NegocioWS.promocion();
            daoNegocio = new NegocioWS.NegocioWSClient();
            dgvCombos.AutoGenerateColumns = false;
            dgvCombos.ScrollBars = ScrollBars.Both;
        }

        public promocion PromoSeleccionada { get => _promoSeleccionada; set => _promoSeleccionada = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvCombos.CurrentRow == null)
                return;
            PromoSeleccionada = (NegocioWS.promocion)dgvCombos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //al apretar enter se muestra los productos
                NegocioWS.promocion[] combos = daoNegocio.listarPromociones_X_nombre(txtBuscarCombo.Text);
                if (combos != null)
                    dgvCombos.DataSource = new BindingList<NegocioWS.promocion>(combos);

            }
        }

        private void txtBuscarCombo_IconRightClick(object sender, EventArgs e)
        {
            NegocioWS.promocion[] combos = daoNegocio.listarPromociones_X_nombre(txtBuscarCombo.Text);
            if (combos != null)
                dgvCombos.DataSource = new BindingList<NegocioWS.promocion>(combos);
        }
    }
}
