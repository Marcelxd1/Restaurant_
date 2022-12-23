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
    public partial class frm_Gestion_Mesas : Form
    {
        private Estado _estado;
        private NegocioWS.NegocioWSClient daonegocio;
        private NegocioWS.mesa mesaSelecc;
        private BindingList<NegocioWS.mesa> lista_mesas; 
        private NegocioWS.mesa _mesa;
        

        public frm_Gestion_Mesas()
        {
            InitializeComponent();
            daonegocio = new NegocioWS.NegocioWSClient();
            _estado = Estado.Inicial;
            establecerComponentes();
            _mesa = new NegocioWS.mesa();
            mesaSelecc = new NegocioWS.mesa();

        }
        
        public void establecerComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    txtID.Text = "";
                    txtCapacidad.Text = "";
                    txtID.Enabled = false;
                    txtCapacidad.Enabled = false;
                    txtCapacidad.ReadOnly = true;
                    txtID.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = false;
                    cargarTabla();
                    break;
                case Estado.Modificar:
                case Estado.Nuevo:
                    txtID.Enabled = false;
                    txtCapacidad.Enabled = true;
                    txtCapacidad.ReadOnly = false;
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    break;
            }
        }

        private void limpiar()
        {
            txtCapacidad.Text = "";
            txtID.Text = "";
            _estado = Estado.Inicial;
            establecerComponentes();
        }

        private void cargarTabla()
        {
            NegocioWS.mesa[] mesas = daonegocio.listarTodasMesa();
            if (mesas != null)
                dgvMesa.DataSource = new BindingList<NegocioWS.mesa>(mesas);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            establecerComponentes();
        }


        private void dgvMesa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            NegocioWS.mesa mesa = (NegocioWS.mesa)dgvMesa.Rows[e.RowIndex].DataBoundItem;
            dgvMesa.Rows[e.RowIndex].Cells[0].Value = mesa.idMesa;
            dgvMesa.Rows[e.RowIndex].Cells[1].Value = mesa.numMesa;
            dgvMesa.Rows[e.RowIndex].Cells[2].Value = mesa.capacidad;
            if(mesa.disponible)
                dgvMesa.Rows[e.RowIndex].Cells[3].Value = "Disponible";
            else
                dgvMesa.Rows[e.RowIndex].Cells[3].Value = "Ocupado";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            mesaSelecc = (NegocioWS.mesa)dgvMesa.CurrentRow.DataBoundItem;
            txtID.Text = mesaSelecc.idMesa.ToString();
            txtCapacidad.Text= mesaSelecc.capacidad.ToString();
            _estado = Estado.Modificar;
            establecerComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int resultado=0;
            _mesa.numMesa = 10;
            if (txtCapacidad.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una capacidad", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_estado == Estado.Nuevo)
            {
                //_mesa.idMesa = 0;
                _mesa.capacidad = Int32.Parse(txtCapacidad.Text);
                resultado= daonegocio.insertarMesa(_mesa);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado la mesa correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerComponentes();
                }
                else
                    MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_estado == Estado.Modificar)
            {
                _mesa = mesaSelecc;
               _mesa.capacidad = Int32.Parse(txtCapacidad.Text);
                
                resultado = daonegocio.modificarMesa(_mesa);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerComponentes();
                }
                else
                    MessageBox.Show("Ha ocurrido un error con la modificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            mesaSelecc = (NegocioWS.mesa)dgvMesa.CurrentRow.DataBoundItem;
            _mesa = mesaSelecc;
            resultado= daonegocio.eliminarMesa(_mesa.idMesa);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha eliminado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                establecerComponentes();
            }
            else
                MessageBox.Show("Ha ocurrido un error con la eliminacion", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

    }
}
