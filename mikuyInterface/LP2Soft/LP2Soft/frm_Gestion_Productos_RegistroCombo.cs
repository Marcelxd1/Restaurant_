﻿using System;
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
    public partial class frm_Gestion_Productos_RegistroCombo : Form
    {
        private NegocioWS.NegocioWSClient daoNegocio;
        private Estado _estado;
        private NegocioWS.promocion _promo;
        private BindingList<NegocioWS.lineaPromocion> _listaLineas;
        private NegocioWS.producto _prodSelec;
        public frm_Gestion_Productos_RegistroCombo()
        {
            InitializeComponent();
            daoNegocio = new NegocioWS.NegocioWSClient();
            _estado = Estado.Inicial;
            dgvPlatos.AutoGenerateColumns= false;
            dgvLineas.AutoGenerateColumns= false;
            establecerEstadoComponentes();
            
            
        }
        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnSeleccionar.Enabled = false;
                    txtID.Enabled = false;
                    txtCantidad.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtNombre.Enabled = false;
                    txtBuscar.Enabled = false;
                    txtPlato.Enabled = false;
                    txtPrecio.Enabled = false;
                    dgvLineas.Enabled = false;
                    dgvPlatos.Enabled = false;
                    break;
                case Estado.Modificar:
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnSeleccionar.Enabled = true;
                    txtCantidad.Enabled = true;
                    txtID.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtNombre.Enabled = true;
                    txtBuscar.Enabled = true;
                    txtPlato.Enabled = true;
                    txtPrecio.Enabled = true;
                    dgvLineas.Enabled = true;
                    dgvPlatos.Enabled = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSeleccionar.Enabled = false;
                    txtID.Enabled = true;
                    txtCantidad.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtNombre.Enabled = false;
                    txtBuscar.Enabled = false;
                    txtPlato.Enabled = false;
                    txtPrecio.Enabled = false;
                    dgvLineas.Enabled = false;
                    dgvPlatos.Enabled = false;
                    break;

            }
        }
        public void limpiarComponentes()
        {
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            txtBuscar.Text = "";
            txtPlato.Text = "";
            txtPrecio.Text = "";
            txtID.Text = "";
            dgvLineas.DataSource=null;
            dgvPlatos.DataSource=null;
            _promo = new NegocioWS.promocion();
            _listaLineas = new BindingList<NegocioWS.lineaPromocion>();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frm_Gestion_Productos_BusquedaCombo frmBusquedaCombo = new frm_Gestion_Productos_BusquedaCombo();
            if (frmBusquedaCombo.ShowDialog() == DialogResult.OK)
            {
                _promo = frmBusquedaCombo.PromoSeleccionada;
                txtID.Text = _promo.idItemVendible.ToString();
                txtNombre.Text = _promo.nombre;
                txtPrecio.Text = _promo.precio.ToString();
                txtDescripcion.Text = _promo.descripcion;
                dgvLineas.DataSource = _promo.lista_de_Comidas;
                

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //que deberia verificar en este caso?
            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una descripcion", "Mensaje de advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Mensaje de advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPlato.Text.Trim() == "")
            {
                MessageBox.Show("Debe de seleccionar un plato", "Mensaje de advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (txtCantidad.Text == "")
            {
                MessageBox.Show("NO ha ingresado una cantidad", "Mensaje de advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

            if (txtPlato.Text == "")
            {
                MessageBox.Show("NO ha ingresado un plato", "Mensaje de advertencia",
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

            try
            {
                Int32.Parse(txtCantidad.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ha ingresado correctamente la cantidad", "Mensaje de advertencia",
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
                    MessageBox.Show("se ha ingresado correctamente la promocion","Mensaje de confirmacion",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                    txtID.Text = resultado.ToString();
                }
                else
                    MessageBox.Show("Ha ocurrido un error con el registro de la promocion", "Mensaje de error"
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
                }
                else
                    MessageBox.Show("Ha ocurrido un error con la modificación", "Mensaje de error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            establecerEstadoComponentes();
            //este boton solo setea el estado, el boton guardar hace el trabajo
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar esta promocion?"
                ,"Mensaje de confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if (respuesta == DialogResult.Yes)
            {
                int resultado = daoNegocio.eliminarPromocion(_promo.idItemVendible);
                if (resultado != 0)
                    MessageBox.Show("Se ha eliminado correctamente", "Mensaje de Confirmación"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de Confirmación"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
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
                dgvPlatos.DataSource= daoNegocio.listarProductoXNombre(txtBuscar.Text);

            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _prodSelec = new NegocioWS.producto();
            _prodSelec = (NegocioWS.producto)dgvPlatos.CurrentRow.DataBoundItem;
            //this.DialogResult = DialogResult.OK;
            txtPlato.Text = _prodSelec.nombre;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NegocioWS.lineaPromocion linea = new NegocioWS.lineaPromocion();
            //linea.idLineaPromocion = _prodSelec.id generado en BD
            //los insertados al inicio solo tendra id 0
            //pero sacados de la BD ya tendran un id asignado
            linea.estado = true;
            linea.producto = _prodSelec;
            linea.unidades = Int32.Parse(txtCantidad.Text);
            
            _listaLineas.Add(linea);
            dgvLineas.DataSource= _listaLineas;
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NegocioWS.lineaPromocion _lineaSelec;
            _lineaSelec = (NegocioWS.lineaPromocion)dgvLineas.CurrentRow.DataBoundItem;
            try
            {
                _listaLineas.Remove(_lineaSelec);
                dgvLineas.DataSource = _listaLineas;
                //deberian de desactivarse en la BD? 
                //-> si esta creandose aun no esta en BD pero cuando se modifica si
                //si estado modificar entonces -> "eliminarLinea"
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de Confirmación"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}