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
    public partial class frm_Gestion_Gastos : Form
    {
        private Estado _estado;
        private CajaWS.gasto _gasto;
        private CajaWS.CajaWSClient daoCaja;

        public frm_Gestion_Gastos()
        {
            InitializeComponent();
            daoCaja = new CajaWS.CajaWSClient();
            dgvGasto.AutoGenerateColumns = false;
            cargarTabla();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    txtItem.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtCantidad.Enabled = false;
                    break;
                case Estado.Modificar:
                case Estado.Nuevo:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    txtItem.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtCantidad.Enabled = true;
                    break;

            }

            
        }
        public void limpiarComponentes()
        {
            epCantidad.SetError(txtCantidad, "");
            epDescripcion.SetError(txtDescripcion, "");
            epPrecio.SetError(txtPrecio, "");
            epItem.SetError(txtItem, "");
            txtItem.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtTotal.Text = "";
            _gasto = new CajaWS.gasto();

        }

        private void cargarTabla()
        {
            string indicador = "";
            if (txtBuscar.Text != "Ingrese item")
                indicador = txtBuscar.Text;
            CajaWS.gasto[] gastos = daoCaja.listarGastosXNombre(indicador);
            if (gastos != null)
                dgvGasto.DataSource = new BindingList<CajaWS.gasto>(gastos);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (verificarDatos())
            {
                _gasto.item = txtItem.Text.Trim().ToUpper();
                _gasto.precio = Double.Parse(txtPrecio.Text.Trim());
                _gasto.descripcion = txtDescripcion.Text.Trim();
                _gasto.cantidad = int.Parse(txtCantidad.Text.Trim());
                _gasto.restaurante = new CajaWS.restaurante();
                _gasto.restaurante.id_restaurante = 1;
                
                if (_estado == Estado.Nuevo)
                {
                    int resultado = daoCaja.insertarGasto(_gasto);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha registrado correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _estado = Estado.Inicial;
                        establecerEstadoComponentes();
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (_estado == Estado.Modificar)
                {
                    int resultado = daoCaja.modificarGasto(_gasto);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha modificado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _estado = Estado.Inicial;
                        establecerEstadoComponentes();
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con la modificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cargarTabla();
            }
            else { return; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _gasto = (CajaWS.gasto)dgvGasto.CurrentRow.DataBoundItem;
            txtItem.Text = _gasto.item;
            txtDescripcion.Text = _gasto.descripcion;
            txtPrecio.Text = _gasto.precio.ToString("N2");
            txtCantidad.Text = _gasto.cantidad.ToString();
            _estado = Estado.Modificar;
            establecerEstadoComponentes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _gasto = (CajaWS.gasto)dgvGasto.CurrentRow.DataBoundItem;
            int resultado = daoCaja.eliminarGasto(_gasto.id_transaccion);

            if (resultado != 0)
            {
                MessageBox.Show("Se ha eliminado correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            }
            else
                MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cargarTabla();
        }

        private bool verificarDatos()
        {

            if (txtItem.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un item", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtPrecio.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un precio", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una descripción", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtCantidad.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una cantidad", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }

        private void txtBuscar_IconRightClick(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void txtBuscar_DoubleClick(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        // Restricciones para los caracteres de los campos TXT 

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Validar que se completen campos
        private void txtItem_Validating(object sender, CancelEventArgs e)
        {
            if (txtItem.Text.Trim() == "")
            {
                epItem.SetError(txtItem, "Debe ingresar el item");
            }
            else
                epItem.SetError(txtItem, "");
        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrecio.Text.Trim() == "")
            {
                epPrecio.SetError(txtPrecio, "Debe ingresar el precio");
            }
            else
                epPrecio.SetError(txtPrecio, "");
        }

        private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescripcion.Text.Trim() == "")
            {
                epDescripcion.SetError(txtDescripcion, "Debe ingresar una descripción");
            }
            else
                epDescripcion.SetError(txtDescripcion, "");
        }

        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            if (txtCantidad.Text.Trim() == "")
            {
                epCantidad.SetError(txtCantidad, "Debe ingresar una cantidad");
            }
            else
                epCantidad.SetError(txtCantidad, "");
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Trim() == string.Empty)
                return;
            double total = Double.Parse(txtCantidad.Text)*Double.Parse(txtPrecio.Text);
            txtTotal.Text = total.ToString();
        }
    }
}
