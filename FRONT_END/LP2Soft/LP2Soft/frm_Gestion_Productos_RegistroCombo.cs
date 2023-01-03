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
    public partial class frm_Gestion_Productos_RegistroCombo : Form
    {
        private NegocioWS.NegocioWSClient daoNegocio;
        private Estado _estado;
        private NegocioWS.promocion _promo;
        private BindingList<NegocioWS.lineaPromocion> _listaLineas;
        private NegocioWS.producto _prodSelec;
        private BindingList<NegocioWS.lineaPromocion> _lineasEliminadas;
        private BindingList<NegocioWS.categoria> cats;
        private double total = 0.0;
        public frm_Gestion_Productos_RegistroCombo(Estado estado, NegocioWS.promocion promo)
        {
            InitializeComponent();
            daoNegocio = new NegocioWS.NegocioWSClient();
            _estado = estado;
            dgvPlatos.AutoGenerateColumns= false;
            dgvLineas.AutoGenerateColumns= false;
            NegocioWS.categoria categoria = new NegocioWS.categoria();
            cats = new BindingList<NegocioWS.categoria>();
            cats = new BindingList<NegocioWS.categoria>(daoNegocio.listarTodasCategorias().ToList());
            categoria.idCategoria = 0;
            categoria.nombre = "TODOS";
            cats.Insert(0, categoria);
            cbCategoria.DataSource = cats;
            cbCategoria.DisplayMember = "nombre";
            cbCategoria.ValueMember = "idCategoria";
            cargaPlatos();
            dgvPlatos.ScrollBars = ScrollBars.Both;
            dgvLineas.ScrollBars = ScrollBars.Both;
            _promo = promo;
           
            
            establecerEstadoComponentes();
        }

        private void cargaPlatos()
        {
            string ind = "";
            if(txtBuscar.Text != "Ingrese nombre")
                ind = txtBuscar.Text;
            dgvPlatos.DataSource = daoNegocio.listarProductoXNombre(ind,cbCategoria.SelectedIndex,0);
        }
        public async void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Modificar:
                    btnGuardar.Text = "Modificar";
                    btnGuardar.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtNombre.Enabled = true;
                    txtBuscar.Enabled = true;
                    txtPrecio.Enabled = true;
                    btnAgregarProd.Enabled = true;
                    btnQuitarProd.Enabled = true;
                    dgvLineas.Enabled = true;
                    dgvPlatos.Enabled = true;
                    limpiarComponentes();
                    cargaDatos();
                    break;
                case Estado.Nuevo:
                    btnGuardar.Text = "Registrar";
                    btnGuardar.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtNombre.Enabled = true;
                    txtBuscar.Enabled = true;
                    txtPrecio.Enabled = true;
                    btnAgregarProd.Enabled = true;
                    btnQuitarProd.Enabled = true;
                    dgvLineas.Enabled = true;
                    dgvPlatos.Enabled = true;
                    _promo = new NegocioWS.promocion();
                    limpiarComponentes();
                    break;

            }
        }
        public void limpiarComponentes()
        {
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            txtBuscar.Text = "";
            txtPrecio.Text = "";
            this.total = 0.0;
            txtTotal.Text = "";
            dgvLineas.DataSource=null;
            //dgvPlatos.DataSource=null;
            _lineasEliminadas = new BindingList<NegocioWS.lineaPromocion>();
            _listaLineas = new BindingList<NegocioWS.lineaPromocion>();
        }

        private void cargaDatos()
        {
            _promo.lista_de_Comidas = daoNegocio.listarTodosLineaPromo(_promo.idItemVendible);
            _listaLineas = new BindingList<NegocioWS.lineaPromocion>(_promo.lista_de_Comidas.ToList());
            dgvLineas.DataSource = _listaLineas;
            txtDescripcion.Text = _promo.descripcion;
            txtNombre.Text = _promo.nombre;
            txtPrecio.Text = _promo.precio.ToString("N2");
            calcularTotal();
            txtTotal.Text = this.total.ToString("N2");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            frm_Gestion_Productos_BusquedaCombo frmBusquedaCombo = new frm_Gestion_Productos_BusquedaCombo();
            if (frmBusquedaCombo.ShowDialog() == DialogResult.OK)
            {
                //_promo = frmBusquedaCombo.PromoSeleccionada;
                txtNombre.Text = _promo.nombre;
                txtPrecio.Text = _promo.precio.ToString();
                txtDescripcion.Text = _promo.descripcion;

                //solo para ese cargamos las lineas 
                //y no mostrara las que esten desactivadas
                NegocioWS.lineaPromocion[] listAux = daoNegocio.listarTodosLineaPromo(_promo.idItemVendible);
                if (listAux != null)
                {
                    foreach (NegocioWS.lineaPromocion d in listAux)
                    {
                        _listaLineas.Add(d);
                    }
                    _promo.lista_de_Comidas = _listaLineas.ToArray();
                }
                _estado = Estado.Buscar;
                establecerEstadoComponentes();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                       
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("NO ha ingresado una descripcion", "Mensaje de advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("NO ha ingresado un nombre", "Mensaje de advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("NO ha ingresado un precio", "Mensaje de advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Double.Parse(txtPrecio.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ha ingresado correctamente el precio", "Mensaje de advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _promo.descripcion= txtDescripcion.Text;
            _promo.estado = true;
            _promo.nombre = txtNombre.Text;
            _promo.lista_de_Comidas = _listaLineas.ToArray();
            _promo.precio = double.Parse(txtPrecio.Text);
            if (_estado == Estado.Nuevo)
            {
                int resultado = daoNegocio.insertarPromocion(_promo);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha ingresado correctamente la promoción","Mensaje de confirmacion",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Ha ocurrido un error con el registro de la promoción", "Mensaje de error"
                        ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_estado == Estado.Modificar)
            {
                int resultado = daoNegocio.modificarPromocion(_promo);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Mensaje de confirmacion"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("Ha ocurrido un error con la modificación", "Mensaje de error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar esta orden de venta?", 
                "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (dr == DialogResult.Yes)
            {
                int resultado = daoNegocio.eliminarPromocion(_promo.idItemVendible);
                if (resultado != 0)
                    MessageBox.Show("Se ha eliminado correctamente", "Mensaje de Confirmación"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                else
                    MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de Confirmación"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(_estado == Estado.Modificar)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
                
            _estado = Estado.Nuevo;
            establecerEstadoComponentes();
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsLetter(e.KeyChar)) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) )
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //al apretar enter se muestra los productos
                dgvPlatos.DataSource= daoNegocio.listarProductoXNombre(txtBuscar.Text,0,0);

            }
        }

       

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            _prodSelec = (NegocioWS.producto)dgvPlatos.CurrentRow.DataBoundItem;
            foreach (NegocioWS.lineaPromocion linea in this._listaLineas)
            {
                if (linea.producto.idProducto.Equals(_prodSelec.idProducto))
                {
                    linea.unidades += (int)numCantidad.Value;
                    this.calcularTotal();
                    txtTotal.Text = this.total.ToString("N2");
                    dgvLineas.DataSource = _listaLineas;
                    dgvLineas.Refresh();
                    _prodSelec = null;
                    numCantidad.Value = 1;
                    return;
                }
            }
            NegocioWS.lineaPromocion lov = new NegocioWS.lineaPromocion();
            lov.producto = _prodSelec;
            lov.unidades = (int)numCantidad.Value;
            _listaLineas.Add(lov);
            this.calcularTotal();
            txtTotal.Text = total.ToString("N2");
            _prodSelec = null;
            dgvLineas.DataSource = _listaLineas;
            dgvLineas.Refresh();
            numCantidad.Value = 1;
        }

        private void btnQuitarProd_Click(object sender, EventArgs e)
        {
            if (dgvLineas.CurrentRow != null)
            {
                NegocioWS.lineaPromocion lov = (NegocioWS.lineaPromocion)dgvLineas.CurrentRow.DataBoundItem;
                this._listaLineas.Remove(lov);
                this.calcularTotal();
                txtTotal.Text = this.total.ToString("N2");
            }
            else
            {
                MessageBox.Show("Debe seleccionar una linea de orden de venta", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void calcularTotal()
        {
            this.total = 0;
            foreach (NegocioWS.lineaPromocion lov in _listaLineas)
                this.total += lov.producto.precio * lov.unidades ;
        }

        private void dgvLineas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvLineas.DataSource!=null)
                {
                        NegocioWS.lineaPromocion linea = (NegocioWS.lineaPromocion)dgvLineas.Rows[e.RowIndex].DataBoundItem;
                        dgvLineas.Rows[e.RowIndex].Cells[0].Value = linea.producto.nombre;
                        dgvLineas.Rows[e.RowIndex].Cells[1].Value = linea.unidades;
                        dgvLineas.Rows[e.RowIndex].Cells[2].Value = linea.unidades*linea.producto.precio;
                }
            }
            catch (Exception)
            {
                return;
            }

        }

        private void txtBuscar_IconRightClick(object sender, EventArgs e)
        {
            cargaPlatos();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
