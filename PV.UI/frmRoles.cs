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
    public partial class frmRoles : Form
    {
        public int Id { get; set; }
        public enum TypeModo { Registrar, Editar, Eliminar }
        public TypeModo Modo { get; set; }
        public delegate void ActualizarDatos();
        public ActualizarDatos objDelegado;
        private String MensajePregunta;
        private String MensajeRespuesta;

        public frmRoles()
        {
            InitializeComponent();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modo == TypeModo.Registrar)
                {
                    lblTitulo.Text = "REGISTRAR ROL";
                    MensajePregunta = "¿Está seguro de registrar el Rol?";
                    MensajeRespuesta = "El Rol se registró satisfactoriamente";
                }
                else if (Modo == TypeModo.Editar)
                {
                    lblTitulo.Text = "EDITAR ROL";
                    MensajePregunta = "¿Está seguro de editar el Rol?";
                    MensajeRespuesta = "El Rol se editó satisfactoriamente"; ;

                    RolesBC objRolBC = new RolesBC();
                    Roles objRol = objRolBC.RolesObtener(Id);
                    txtAcronimo.Text = objRol.Acronimo;
                    txtDescipcion.Text = objRol.Descripcion;
                }
                else if (Modo == TypeModo.Eliminar)
                {
                    lblTitulo.Text = "ELIMINAR ROL";
                    MensajePregunta = "¿Está seguro de eliminar el Rol?";
                    MensajeRespuesta = "El Rol se eliminó satisfactoriamente";
                    RolesBC objRolBC = new RolesBC();
                    Roles objRol = objRolBC.RolesObtener(Id);
                    txtAcronimo.Text = objRol.Acronimo;
                    txtDescipcion.Text = objRol.Descripcion;
                }
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
            if (MessageBox.Show(MensajePregunta, this.Text,
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
            DialogResult.Yes)
                return;

            RolesBC objRolesBC = new RolesBC();
            Roles objRoles = new Roles();
            objRoles.Acronimo = txtAcronimo.Text;
            objRoles.Descripcion = txtDescipcion.Text;

            if (Modo == TypeModo.Editar)
            {
                objRoles.RolId = Id;
                objRolesBC.RolesEditar(objRoles);
            }
            else if (Modo == TypeModo.Registrar)
            {
                objRolesBC.RolesRegistrar(objRoles);
            }
            else if (Modo == TypeModo.Eliminar)
            {
                objRoles.RolId = Id;
                objRolesBC.RolesEliminar(Id);
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
