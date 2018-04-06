using PV.BC;
using PV.DL.DataModel;
using System;
using System.Windows.Forms;

namespace PV.UI
{
    public partial class frmAdmUsuarios : Form
    {
        public frmAdmUsuarios()
        {
            InitializeComponent();
        }

        private void frmAdmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Estas seguro que deseas salir ?",
                     "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(dialog == DialogResult.Yes))
            {
                e.Cancel = true;
            }
        }

        private void ConfigurarComponentes()
        {
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarDatos()
        {
            UsuariosBC objUsuarioBC = new UsuariosBC();

            dgvUsuarios.DataSource = objUsuarioBC.ProcedureUsuario();
            dgvUsuarioConfigurar();
        }

        private void dgvUsuarioConfigurar()
        {
            dgvUsuarios.Columns["UsuarioId"].DisplayIndex = 0;
            dgvUsuarios.Columns["UsuarioId"].Width = 150;
            dgvUsuarios.Columns["Nombre"].DisplayIndex = 1;
            dgvUsuarios.Columns["Nombre"].Width = 150;
            dgvUsuarios.Columns["Paterno"].DisplayIndex = 2;
            dgvUsuarios.Columns["Paterno"].Width = 150;
            dgvUsuarios.Columns["Materno"].DisplayIndex = 3;
            dgvUsuarios.Columns["Materno"].Width = 150;
            dgvUsuarios.Columns["Rol"].DisplayIndex = 4;
            dgvUsuarios.Columns["Rol"].Width = 150;
            dgvUsuarios.Columns["Usuario"].DisplayIndex = 5;
            dgvUsuarios.Columns["Usuario"].Width = 150;
        }

        private void frmAdmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarComponentes();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema, por favor intente más tarde.\n" +
                   ex.Message.ToString() + "\n\n"+ ex.StackTrace + "\n", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsuarios frm = new frmUsuarios();
                frm.Modo = frmUsuarios.TypeModo.Registrar;
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
                if (dgvUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccionar el elemento.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int Id = Convert.ToInt32(dgvUsuarios.SelectedRows[0]
                    .Cells["UsuarioId"].Value);
                frmUsuarios frm = new frmUsuarios();
                frm.Modo = frmUsuarios.TypeModo.Editar;
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
                if (dgvUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccionar el elemento.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int Id = Convert.ToInt32(dgvUsuarios.SelectedRows[0]
                    .Cells["UsuarioId"].Value);
                frmUsuarios frm = new frmUsuarios();
                frm.Modo = frmUsuarios.TypeModo.Eliminar;
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
                CargarDatosBusqueda();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema, por favor intente más tarde.\n\n"
                    + ex.Message.ToString() + "\n\n" + ex.StackTrace.ToString(), this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosBusqueda()
        {
            UsuariosBC objUsuarioBC = new UsuariosBC();

            dgvUsuarios.DataSource = objUsuarioBC.Busqueda(txtBusqueda.Text);
            dgvBusqueda();
        }

        private void dgvBusqueda()
        {
            dgvUsuarios.Columns["UsuarioId"].DisplayIndex = 0;
            dgvUsuarios.Columns["UsuarioId"].Width = 150;
            dgvUsuarios.Columns["Nombre"].DisplayIndex = 1;
            dgvUsuarios.Columns["Nombre"].Width = 150;
            dgvUsuarios.Columns["Paterno"].DisplayIndex = 2;
            dgvUsuarios.Columns["Paterno"].Width = 150;
            dgvUsuarios.Columns["Materno"].DisplayIndex = 3;
            dgvUsuarios.Columns["Materno"].Width = 150;
            dgvUsuarios.Columns["RolId"].DisplayIndex = 4;
            dgvUsuarios.Columns["RolId"].Width = 150;
            dgvUsuarios.Columns["Usuario"].DisplayIndex = 5;
            dgvUsuarios.Columns["Usuario"].Width = 150;
            dgvUsuarios.Columns["Roles"].Visible = false;
            dgvUsuarios.Columns["Contraseña"].Visible = false;
            dgvUsuarios.Columns["DetalleVentas"].Visible = false;
            dgvUsuarios.Columns["DetalleCompras"].Visible = false;
            dgvUsuarios.Columns["Sesiones"].Visible = false;
            dgvUsuarios.Columns["Ventas"].Visible = false;
        }
    }
}
