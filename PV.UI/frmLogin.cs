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

namespace PV.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void InicializarControles()
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Ingresa tu Usuario !",
                   this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
            else if (txtContraseña.Text == "")
            {
                MessageBox.Show("Ingresa tu Contraseña !",
                   this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
            }
            return;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            InicializarControles();

            UsuariosBC objUsuarioBC = new UsuariosBC();

            SesionesBC objSesionBC = new SesionesBC();
            Sesiones objSesion = new Sesiones();

            Usuarios objUsuarios = objUsuarioBC.ValidarUsuarios(txtUsuario.Text,
                txtContraseña.Text);

            if (objUsuarios == null)
            {
                MessageBox.Show(" Usuario y / o contraseña incorrectas ",
                   this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //Insertan los datos en la tabla Sesiones 
                objSesion.RolId = objUsuarios.RolId;
                objSesion.UsuarioId = objUsuarios.UsuarioId;
                objSesion.Activo = "ACT";
                objSesion.FechaInicioSesion = DateTime.Now;
                objSesion.FechaCierreSesion = DateTime.Now;

                objSesionBC.SesionesRegistrar(objSesion);

                //LLama al Punto de Venta
                frmPuntoVenta frm = new frmPuntoVenta();
                this.Hide();
               frm.ShowDialog();
                this.Show();
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                txtUsuario.Focus();
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
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
