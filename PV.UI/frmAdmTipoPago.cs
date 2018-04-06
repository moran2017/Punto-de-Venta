using PV.BC;
using System;
using System.Windows.Forms;

namespace PV.UI
{
    public partial class frmAdmTipoPago : Form
    {
        public frmAdmTipoPago()
        {
            InitializeComponent();
        }
        private void ConfigurarComponentes()
        {
            dgvTiposPagos.MultiSelect = false;
            dgvTiposPagos.AllowUserToAddRows = false;
            dgvTiposPagos.AllowUserToDeleteRows = false;
            dgvTiposPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarDatos()
        {
            TipoPagosBC objTipoPagoBC = new TipoPagosBC();
            dgvTiposPagos.DataSource = objTipoPagoBC.Busqueda(txtBusqueda.Text);
            dgvTipoPagosConfigurar();
        }

        private void dgvTipoPagosConfigurar()
        {
            dgvTiposPagos.Columns["TipoPagoId"].DisplayIndex = 0;
            dgvTiposPagos.Columns["TipoPagoId"].Width = 150;
            dgvTiposPagos.Columns["Acronimo"].DisplayIndex = 1;
            dgvTiposPagos.Columns["Acronimo"].Width = 150;
            dgvTiposPagos.Columns["Descripcion"].DisplayIndex = 2;
            dgvTiposPagos.Columns["Descripcion"].Width = 150;
            dgvTiposPagos.Columns["DetalleVentas"].Visible = false;
            dgvTiposPagos.Columns["Ventas"].Visible = false;
        }

        private void frmAdmTipoPago_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarComponentes();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema, por favor intente más tarde.\n" +
                   ex.Message.ToString(), this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                frmTipoPagos frm = new frmTipoPagos();
                frm.Modo = frmTipoPagos.TypeModo.Registrar;
                frm.objDelegado += CargarDatos;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema, por favor intente más tarde.\n"
                   + ex.Message.ToString(), this.Text,
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTiposPagos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccionar el elemento.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int Id = Convert.ToInt32(dgvTiposPagos.SelectedRows[0]
                    .Cells["TipoPagoId"].Value);
                frmTipoPagos frm = new frmTipoPagos();
                frm.Modo = frmTipoPagos.TypeModo.Editar;
                frm.Id = Id;
                frm.objDelegado += CargarDatos;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema, por favor intente más tarde.\n"
                   + ex.Message.ToString(), this.Text,
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTiposPagos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccionar el elemento.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int Id = Convert.ToInt32(dgvTiposPagos.SelectedRows[0]
                    .Cells["TipoPagoId"].Value);
                frmTipoPagos frm = new frmTipoPagos();
                frm.Modo = frmTipoPagos.TypeModo.Eliminar;
                frm.Id = Id;
                frm.objDelegado += CargarDatos;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema, por favor intente más tarde.\n"
                    + ex.Message.ToString(), this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema, por favor intente más tarde.\n"
                    + ex.Message.ToString(), this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAdmTipoPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Estas seguro que deseas salir ?",
               this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(dialog == DialogResult.Yes))
            {
                e.Cancel = true;
            }
        }
    }
}
