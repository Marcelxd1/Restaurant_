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
        private frm_Gestion_Productos_RegistroCombo combosModify;
        public frm_Gestion_Productos_BusquedaCombo()
        {
            InitializeComponent();
            _promoSeleccionada = new NegocioWS.promocion();
            daoNegocio = new NegocioWS.NegocioWSClient();
            dgvCombos.AutoGenerateColumns = false;
            dgvCombos.ScrollBars = ScrollBars.Both;
            cargarTabla();
        }
             

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cargarTabla();

            }
        }

        private void cargarTabla()
        {
            string indicador = "";
            if (txtBuscarCombo.Text != "Inserte nombre")
                indicador = txtBuscarCombo.Text;
            NegocioWS.promocion[] combos = daoNegocio.listarPromociones_X_nombre(indicador);
            dgvCombos.DataSource = new BindingList<NegocioWS.promocion>(combos);
        }

        private void txtBuscarCombo_IconRightClick(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frm_Gestion_Productos_RegistroCombo frmProdc = new frm_Gestion_Productos_RegistroCombo(Estado.Nuevo, null);
            if (frmProdc.ShowDialog() == DialogResult.OK)
            {
                cargarTabla();
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            frm_Loading frm_Loading = new frm_Loading();
            frm_Loading.Show();
            Task hilo1 = new Task(InicializarForm);
            hilo1.Start();
            await hilo1;
            frm_Loading.Hide();
        }

        private void InicializarForm()
        {
            combosModify = new frm_Gestion_Productos_RegistroCombo(Estado.Modificar, (NegocioWS.promocion)dgvCombos.CurrentRow.DataBoundItem);

            if (combosModify.ShowDialog() == DialogResult.OK)
            {
                cargarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar esta orden de venta?",
               "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (dr == DialogResult.Yes)
            {
                _promoSeleccionada = (NegocioWS.promocion)dgvCombos.CurrentRow.DataBoundItem;
                int resultado = daoNegocio.eliminarPromocion(_promoSeleccionada.idItemVendible);
                if (resultado != 0)
                    MessageBox.Show("Se ha eliminado correctamente", "Mensaje de Confirmación"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                else
                    MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de Confirmación"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            
        }
    }
}
