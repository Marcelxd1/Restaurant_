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
    public partial class frm_Gestion_Productos_ListarPlatos : Form
    {
        private Estado _estado;
        private NegocioWS.producto _producto;
        private NegocioWS.NegocioWSClient daoNegocio;
        private BindingList<NegocioWS.categoria> cats;
        
        public frm_Gestion_Productos_ListarPlatos()
        {
            InitializeComponent();
            daoNegocio = new NegocioWS.NegocioWSClient();
            dgvProductos.AutoGenerateColumns = false;
            NegocioWS.categoria categoria = new NegocioWS.categoria();
            cats = new BindingList<NegocioWS.categoria>(daoNegocio.listarTodasCategorias().ToList());
            categoria.idCategoria = 0;
            categoria.nombre = "TODOS";
            cats.Insert(0, categoria);
            cbCategoria.DataSource = cats;
            cbCategoria.DisplayMember = "nombre";
            cbCategoria.ValueMember = "idCategoria";
            cargarTabla();
            dgvProductos.Columns[3].DefaultCellStyle.Format = "00.00";
        }

        private void cargarTabla()
        {
            char i='C';
            if (rbBebida.Checked)
                i = 'B';
            if (rbComida.Checked)
                i = 'C';
            string indicador = "";
            if (txtBuscar.Text != "Buscar")
                indicador = txtBuscar.Text;
            dgvProductos.DataSource = daoNegocio.listarProductoXNombre(indicador, cbCategoria.SelectedIndex, i);
        }

        private void txtBuscar_IconRightClick(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void txtBuscar_DoubleClick(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            NegocioWS.producto producto = (NegocioWS.producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;
            dgvProductos.Rows[e.RowIndex].Cells[0].Value = producto.idProducto;
            dgvProductos.Rows[e.RowIndex].Cells[1].Value = producto.categoria.nombre;
            dgvProductos.Rows[e.RowIndex].Cells[2].Value = producto.nombre;
            dgvProductos.Rows[e.RowIndex].Cells[3].Value = producto.precio;
            
            dgvProductos.Rows[e.RowIndex].Cells[4].Value = producto.presentacion;


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frm_Gestion_Productos_RegistroPlatos frmProdc = new frm_Gestion_Productos_RegistroPlatos(Estado.Nuevo,null);
            if (frmProdc.ShowDialog() == DialogResult.OK)
            {
                cargarTabla();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frm_Gestion_Productos_RegistroPlatos frmProdc = new frm_Gestion_Productos_RegistroPlatos(
                Estado.Modificar, (NegocioWS.producto)dgvProductos.CurrentRow.DataBoundItem);
            if (frmProdc.ShowDialog() == DialogResult.OK)
            {
                cargarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _producto = (NegocioWS.producto)dgvProductos.CurrentRow.DataBoundItem;
            int resultado = daoNegocio.eliminarProducto(_producto.idProducto);

            if (resultado != 0)
            {
                MessageBox.Show("Se ha eliminado correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
                MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cargarTabla();
        }

        private void rbBebida_CheckedChanged(object sender, EventArgs e)
        {
            cargarTabla();
        }
    }
}
