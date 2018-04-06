using PV.BC;
using PV.DL.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PV.BC.UsuariosBC;

namespace PV.UI
{
    public partial class frmPuntoVenta : Form
    {
        public int Id { get; set; }
        public frmPuntoVenta()
        {
            InitializeComponent();
        }

        private void frmPuntoVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                DialogResult dialog = MessageBox.Show("Estas seguro que deseas salir ?",
                        this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (!(dialog == DialogResult.Yes))
                {
                    e.Cancel = true;
                }
            }
        }

        private void frmPuntoVenta_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToLongDateString();
            lblVesion.Text = "V20180328.a";
            txtBusquedaProducto.Focus();

            Usuarios objUsuarioBC = new Usuarios();
            /*
            UsuariosBC objUsuarioBC = new UsuariosBC();
            Usuarios objUsuarios = objUsuarioBC.UsuariosObtener(Id);

            if (objUsuarios.RolId == 8)
            {
                //Usuario Administrador
                menuReportes.Visible = true;
                menuUsuarios.Visible = true;
                menuProductos.Visible = true;
                menuMarca.Visible = true;
                menuProveedores.Visible = true;
                menuTipoProductos.Visible = true;

            }
            else if (objUsuarios.RolId == 9)
            {
                //Usuario Vendedor
                menuReportes.Visible = false;
                menuUsuarios.Visible = false;
                menuProductos.Visible = false;
                menuMarca.Visible = false;
                menuProveedores.Visible = false;
                menuTipoProductos.Visible = false;
            }
            else if (objUsuarios.RolId == 10)
            {
                //Usuario Opererador
                menuReportes.Visible = false;
                menuUsuarios.Visible = true;
                menuProductos.Visible = false;
                menuMarca.Visible = false;
                menuProveedores.Visible = true;
                menuTipoProductos.Visible = false;
            }
            else if (objUsuarios.RolId == 11)
            {
                //Usuario Supervisor
                menuReportes.Visible = true;
                menuUsuarios.Visible = true;
                menuProductos.Visible = false;
                menuMarca.Visible = false;
                menuProveedores.Visible = false;
                menuTipoProductos.Visible = false;
            }
            */
        }

        private void menuMarca_Click(object sender, EventArgs e)
        {
            frmAdmMarcas frm = new frmAdmMarcas();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void menuProductos_Click(object sender, EventArgs e)
        {
            frmAdmProductos frm = new frmAdmProductos();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            frmAdmProveedores frm = new frmAdmProveedores();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuRoles_Click(object sender, EventArgs e)
        {
            frmAdmRoles frm = new frmAdmRoles();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void MenuTiposPago_Click(object sender, EventArgs e)
        {
            frmAdmTipoPago frm = new frmAdmTipoPago();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void menuTipoProductos_Click(object sender, EventArgs e)
        {
            frmAdmTipoProductos frm = new frmAdmTipoProductos();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            frmAdmUsuarios frm = new frmAdmUsuarios();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void menuSesiones_Click(object sender, EventArgs e)
        {
            frmAdmSesiones frm = new frmAdmSesiones();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
