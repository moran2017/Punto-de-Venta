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
    public partial class frmAdmMarcas : Form
    {
        public frmAdmMarcas()
        {
            InitializeComponent();
        }

        private void frmAdmMarcas_FormClosing(object sender, FormClosingEventArgs e)
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
            dgvMarcas.MultiSelect = false;
            dgvMarcas.AllowUserToAddRows = false;
            dgvMarcas.AllowUserToDeleteRows = false;
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarDatos()
        {
            MarcasBC objMarcasBC = new MarcasBC();
            dgvMarcas.DataSource = objMarcasBC.Busqueda(txtBusqueda.Text);
            dgvMarcaConfigurar();
        }

        private void dgvMarcaConfigurar()
        {
            dgvMarcas.Columns["MarcaId"].DisplayIndex = 0;
            dgvMarcas.Columns["MarcaId"].Width = 150;
            dgvMarcas.Columns["Nombre"].DisplayIndex = 1;
            dgvMarcas.Columns["Nombre"].Width = 150;
            dgvMarcas.Columns["Descripcion"].DisplayIndex = 2;
            dgvMarcas.Columns["Descripcion"].Width = 150;
            dgvMarcas.Columns["Productos"].Visible = false;
            dgvMarcas.Columns["DetalleCompras"].Visible = false;

        }

        private void frmAdmMarcas_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarComponentes();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema, por favor intente más tarde.\n"
                    + ex.Message.ToString(), this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMarcas frm = new frmMarcas();
                frm.Modo = frmMarcas.TypeModo.Registrar;
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
                if (dgvMarcas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccionar el elemento.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int Id = Convert.ToInt32(dgvMarcas.SelectedRows[0]
                    .Cells["MarcaId"].Value);
                frmMarcas frm = new frmMarcas();
                frm.Modo = frmMarcas.TypeModo.Editar;
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
                if (dgvMarcas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccionar el elemento.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int Id = Convert.ToInt32(dgvMarcas.SelectedRows[0]
                    .Cells["MarcaId"].Value);
                frmMarcas frm = new frmMarcas();
                frm.Modo = frmMarcas.TypeModo.Eliminar;
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
