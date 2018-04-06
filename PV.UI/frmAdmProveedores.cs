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
    public partial class frmAdmProveedores : Form
    {
        public frmAdmProveedores()
        {
            InitializeComponent();
        }

        private void frmAdmProveedores_FormClosing(object sender, FormClosingEventArgs e)
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
            dgvProveedores.MultiSelect = false;
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AllowUserToDeleteRows = false;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarDatos()
        {
            ProveedoresBC objProveedoresBC = new ProveedoresBC();
            dgvProveedores.DataSource = objProveedoresBC.Busqueda(txtBusqueda.Text);
            dgvProveedorConfigurar();
        }

        private void dgvProveedorConfigurar()
        {
            dgvProveedores.Columns["ProveedorId"].DisplayIndex = 0;
            dgvProveedores.Columns["ProveedorId"].Width = 150;
            dgvProveedores.Columns["Nombre"].DisplayIndex = 1;
            dgvProveedores.Columns["Nombre"].Width = 150;
            dgvProveedores.Columns["TipoProductos"].Visible = false;
        }

        private void frmAdmProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarComponentes();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema, por favor intente más tarde." +
                    ex.Message.ToString(), this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                frmProveedores frm = new frmProveedores();
                frm.Modo = frmProveedores.TypeModo.Registrar;
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
                if (dgvProveedores.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccionar el elemento.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int Id = Convert.ToInt32(dgvProveedores.SelectedRows[0]
                    .Cells["ProveedorId"].Value);
                frmProveedores frm = new frmProveedores();
                frm.Modo = frmProveedores.TypeModo.Editar;
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
                if (dgvProveedores.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccionar el elemento.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int Id = Convert.ToInt32(dgvProveedores.SelectedRows[0]
                    .Cells["ProveedorId"].Value);
                frmProveedores frm = new frmProveedores();
                frm.Modo = frmProveedores.TypeModo.Eliminar;
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
