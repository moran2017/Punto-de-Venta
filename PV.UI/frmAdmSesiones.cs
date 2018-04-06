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
    public partial class frmAdmSesiones : Form
    {
        public frmAdmSesiones()
        {
            InitializeComponent();
        }
        private void ConfigurarComponentes()
        {
            dgvSesiones.MultiSelect = false;
            dgvSesiones.AllowUserToAddRows = false;
            dgvSesiones.AllowUserToDeleteRows = false;
            dgvSesiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarDatos()
        {
            SesionesBC objSesionBC = new SesionesBC();
            dgvSesiones.DataSource = objSesionBC.Busqueda(txtBusqueda.Text);
            dgvSesionesConfigurar();
        }

        private void dgvSesionesConfigurar()
        {
            dgvSesiones.Columns["SesionId"].DisplayIndex = 0;
            dgvSesiones.Columns["SesionId"].Width = 150;
            dgvSesiones.Columns["RolId"].DisplayIndex = 1;
            dgvSesiones.Columns["RolId"].Width = 150;
            dgvSesiones.Columns["Activo"].DisplayIndex = 2;
            dgvSesiones.Columns["Activo"].Width = 150;
            dgvSesiones.Columns["FechaInicioSesion"].DisplayIndex = 3;
            dgvSesiones.Columns["FechaInicioSesion"].Width = 150;
            dgvSesiones.Columns["FechaCierreSesion"].DisplayIndex = 4;
            dgvSesiones.Columns["FechaCierreSesion"].Width = 150;
            dgvSesiones.Columns["Roles"].Visible = false;
            dgvSesiones.Columns["Usuarios"].Visible = false;
        }

        private void frmAdmSesiones_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Estas seguro que deseas salir ?",
               this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(dialog == DialogResult.Yes))
            {
                e.Cancel = true;
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

        private void frmAdmSesiones_Load(object sender, EventArgs e)
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
    }
}
