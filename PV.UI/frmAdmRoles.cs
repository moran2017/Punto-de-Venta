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
    public partial class frmAdmRoles : Form
    {
        public frmAdmRoles()
        {
            InitializeComponent();
        }

        private void ConfigurarComponentes()
        {
            dgvRoles.MultiSelect = false;
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarDatos()
        {
            RolesBC objRolesBC = new RolesBC();
            dgvRoles.DataSource = objRolesBC.Busqueda(txtBusqueda.Text);
            dgvRolesConfigurar();
        }

        private void dgvRolesConfigurar()
        {
            dgvRoles.Columns["RolId"].DisplayIndex = 0;
            dgvRoles.Columns["RolId"].Width = 150;
            dgvRoles.Columns["Acronimo"].DisplayIndex = 1;
            dgvRoles.Columns["Acronimo"].Width = 150;
            dgvRoles.Columns["Descripcion"].DisplayIndex = 2;
            dgvRoles.Columns["Descripcion"].Width = 150;
            dgvRoles.Columns["Sesiones"].Visible = false;
            dgvRoles.Columns["Usuarios"].Visible = false;
        }

        private void frmAdmRoles_Load(object sender, EventArgs e)
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
                frmRoles frm = new frmRoles();
                frm.Modo = frmRoles.TypeModo.Registrar;
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
                if (dgvRoles.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccionar el elemento.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int Id = Convert.ToInt32(dgvRoles.SelectedRows[0]
                    .Cells["RolId"].Value);
                frmRoles frm = new frmRoles();
                frm.Modo = frmRoles.TypeModo.Editar;
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
                if (dgvRoles.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccionar el elemento.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int Id = Convert.ToInt32(dgvRoles.SelectedRows[0]
                    .Cells["RolId"].Value);
                frmRoles frm = new frmRoles();
                frm.Modo = frmRoles.TypeModo.Eliminar;
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

        private void frmAdmRoles_FormClosing(object sender, FormClosingEventArgs e)
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
