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
    public partial class frmUsuarios : Form
    {
        public int Id { get; set; }
        public enum TypeModo { Registrar, Editar, Eliminar }
        public TypeModo Modo { get; set; }
        public delegate void ActualizarDatos();
        public ActualizarDatos objDelegado;
        private String MensajePregunta;
        private String MensajeRespuesta;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Estas seguro que deseas salir ?",
                   this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(dialog == DialogResult.Yes))
            {
                e.Cancel = true;
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modo == TypeModo.Registrar)
                {
                    lblTitulo.Text = "REGISTRAR USUARIO";
                    MensajePregunta = "¿Está seguro de registrar el Usuario?";
                    MensajeRespuesta = "El Usuario se registró satisfactoriamente";

                    UsuariosBC objUsuarioBC = new UsuariosBC();
                    Usuarios objUsuario = objUsuarioBC.UsuariosObtener(Id);

                    RolesBC objRol = new RolesBC();

                    cbRol.DataSource = objRol.RolesListar();
                    cbRol.DisplayMember = "Descripcion";
                    cbRol.ValueMember = "RolId";

                }
                else if (Modo == TypeModo.Editar)
                {
                    lblTitulo.Text = "EDITAR USUARIO";
                    MensajePregunta = "¿Está seguro de editar el Usuario?";
                    MensajeRespuesta = "El Usuario se editó satisfactoriamente"; ;

                    UsuariosBC objUsuarioBC = new UsuariosBC();
                    Usuarios objUsuario = objUsuarioBC.UsuariosObtener(Id);

                    txtNombre.Text = (String.Format(objUsuario.Nombre.ToString()));
                    txtPaterno.Text = (String.Format(objUsuario.Paterno.ToString()));
                    txtMaterno.Text = (String.Format(objUsuario.Materno.ToString()));

                    RolesBC objRol = new RolesBC();
                    cbRol.DataSource = objRol.RolesListar();
                    cbRol.DisplayMember = "Descripcion";
                    cbRol.ValueMember = "RolId";

                    txtUsuario.Text = (String.Format(objUsuario.Usuario.
                        ToString()));
                    txtContraseña.Text = String.Format(objUsuario.Contraseña.
                        ToString());

                }
                else if (Modo == TypeModo.Eliminar)
                {
                    lblTitulo.Text = "ELIMINAR USUARIO";
                    MensajePregunta = "¿Está seguro de eliminar el Usuario?";
                    MensajeRespuesta = "El Usuario se elimino satisfactoriamente";
                    UsuariosBC objUsuarioBC = new UsuariosBC();
                    Usuarios objUsuario = objUsuarioBC.UsuariosObtener(Id);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el sistema, por favor intente más tarde.", this.Text,
                  MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(MensajePregunta, this.Text,
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
              DialogResult.Yes)
                return;

            UsuariosBC objUsuarioBC = new UsuariosBC();
            Usuarios objUsuario = new Usuarios();

            objUsuario.Nombre = txtNombre.Text;
            objUsuario.Paterno = txtPaterno.Text;
            objUsuario.Materno = txtMaterno.Text;
            objUsuario.RolId = Convert.ToInt32(cbRol.SelectedValue.ToString());
            objUsuario.Usuario = txtUsuario.Text;
            objUsuario.Contraseña = txtContraseña.Text;

            if (Modo == TypeModo.Editar)
            {
                objUsuario.UsuarioId = Id;
                objUsuarioBC.UsuariosEditar(objUsuario);
            }
            else if (Modo == TypeModo.Registrar)
            {
                objUsuarioBC.UsuariosRegistrar(objUsuario);
            }
            else if (Modo == TypeModo.Eliminar)
            {
                objUsuario.UsuarioId = Id;
                objUsuarioBC.UsuariosEliminar(Id);
            }
            objDelegado();
            MessageBox.Show(MensajeRespuesta, this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
