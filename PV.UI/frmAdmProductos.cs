using PV.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV.UI
{
    public partial class frmAdmProductos : Form
    {
        public frmAdmProductos()
        {
            InitializeComponent();
        }

        private void frmAdmProductos_FormClosing(object sender, FormClosingEventArgs e)
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
            dgvProductos.MultiSelect = false;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarDatos()
        {
            ProductosBC objProductoBC = new ProductosBC();
            dgvProductos.DataSource = objProductoBC.Busqueda(txtBusqueda.Text);
            dgvProductoConfigurar();
        }

        private void dgvProductoConfigurar()
        {
            dgvProductos.Columns["ProductoId"].DisplayIndex = 0;
            dgvProductos.Columns["ProductoId"].Width = 150;
            dgvProductos.Columns["TipoProductoId"].DisplayIndex = 1;
            dgvProductos.Columns["TipoProductoId"].Width = 150;
            dgvProductos.Columns["MarcaId"].DisplayIndex = 2;
            dgvProductos.Columns["MarcaId"].Width = 150;
            dgvProductos.Columns["Nombre"].DisplayIndex = 3;
            dgvProductos.Columns["Nombre"].Width = 150;
            dgvProductos.Columns["MarcaId"].DisplayIndex = 4;
            dgvProductos.Columns["MarcaId"].Width = 150;
            dgvProductos.Columns["PrecioCompra"].DisplayIndex = 5;
            dgvProductos.Columns["PrecioCompra"].Width = 150;
            dgvProductos.Columns["PrecioVenta"].DisplayIndex = 6;
            dgvProductos.Columns["PrecioVenta"].Width = 150;
            dgvProductos.Columns["Codigo"].DisplayIndex = 7;
            dgvProductos.Columns["Codigo"].Width = 150;
            dgvProductos.Columns["DetalleVentas"].Visible = false;
            dgvProductos.Columns["Marcas"].Visible = false;
            dgvProductos.Columns["TipoProductos"].Visible = false;
        }

        private void frmAdmProductos_Load(object sender, EventArgs e)
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
                frmProductos frm = new frmProductos();
                frm.Modo = frmProductos.TypeModo.Registrar;
                frm.objDelegado += CargarDatos;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema, por favor intente más tarde.\n\n" +
                                  ex.Message.ToString() + "\n\n" +
                                  ex.InnerException.ToString(), this.Text,
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccionar el elemento.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int Id = Convert.ToInt32(dgvProductos.SelectedRows[0]
                    .Cells["ProductoId"].Value);
                frmProductos frm = new frmProductos();
                frm.Modo = frmProductos.TypeModo.Editar;
                frm.Id = Id;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccionar el elemento.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int Id = Convert.ToInt32(dgvProductos.SelectedRows[0]
                    .Cells["ProductoId"].Value);
                frmProductos frm = new frmProductos();
                frm.Modo = frmProductos.TypeModo.Eliminar;
                frm.Id = Id;
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
    }
}
