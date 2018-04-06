using PV.BC;
using System;
using System.Windows.Forms;

namespace PV.UI
{
    public partial class frmAdmTipoProductos : Form
    {
        public frmAdmTipoProductos()
        {
            InitializeComponent();
        }

        private void frmAdmTipoProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Estas seguro que deseas salir ?",
                    this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(dialog == DialogResult.Yes))
            {
                e.Cancel = true;
            }
        }

        private void ConfigurarComponentes()
        {
            dgvTiposProductos.MultiSelect = false;
            dgvTiposProductos.AllowUserToAddRows = false;
            dgvTiposProductos.AllowUserToDeleteRows = false;
            dgvTiposProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarDatos()
        {
            TipoProductosBC obPjipoProductoBC = new TipoProductosBC();
            dgvTiposProductos.DataSource = obPjipoProductoBC.Busqueda(txtBusqueda.Text);
            dgvTipoProductosConfigurar();
        }

        private void dgvTipoProductosConfigurar()
        {
            dgvTiposProductos.Columns["TipoProductoId"].DisplayIndex = 0;
            dgvTiposProductos.Columns["TipoProductoId"].Width = 150;
            dgvTiposProductos.Columns["Nombre"].DisplayIndex = 1;
            dgvTiposProductos.Columns["Nombre"].Width = 150;
            dgvTiposProductos.Columns["ProveedorId"].DisplayIndex = 2;
            dgvTiposProductos.Columns["ProveedorId"].Width = 150;
            dgvTiposProductos.Columns["Descripcion"].DisplayIndex = 3;
            dgvTiposProductos.Columns["Descripcion"].Width = 150;
            dgvTiposProductos.Columns["DetalleVentas"].Visible = false;
            dgvTiposProductos.Columns["Productos"].Visible = false;
            dgvTiposProductos.Columns["Ventas"].Visible = false;
            dgvTiposProductos.Columns["Proveedores"].Visible = false;
        }

        private void frmAdmTipoProductos_Load(object sender, EventArgs e)
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
                frmTipoProductos frm = new frmTipoProductos();
                frm.Modo = frmTipoProductos.TypeModo.Registrar;
                frm.objDelegado += CargarDatos;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema, por favor intente más tarde.\n" +
                                  ex.Message.ToString(), this.Text,
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTiposProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccionar el elemento.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int Id = Convert.ToInt32(dgvTiposProductos.SelectedRows[0]
                    .Cells["TipoProductoId"].Value);
                frmTipoProductos frm = new frmTipoProductos();
                frm.Modo = frmTipoProductos.TypeModo.Editar;
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
                if (dgvTiposProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccionar el elemento.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int Id = Convert.ToInt32(dgvTiposProductos.SelectedRows[0]
                    .Cells["TipoProductoId"].Value);
                frmTipoProductos frm = new frmTipoProductos();
                frm.Modo = frmTipoProductos.TypeModo.Eliminar;
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
    }
}
