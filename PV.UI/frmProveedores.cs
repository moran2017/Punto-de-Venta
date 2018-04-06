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
    public partial class frmProveedores : Form
    {
        public int Id { get; set; }
        public enum TypeModo { Registrar, Editar, Eliminar }
        public TypeModo Modo { get; set; }
        public delegate void ActualizarDatos();
        public ActualizarDatos objDelegado;
        private String MensajePregunta;
        private String MensajeRespuesta;

        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Estas seguro que deseas salir ?",
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(dialog == DialogResult.Yes))
            {
                e.Cancel = true;
            }
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modo == TypeModo.Registrar)
                {
                    lblTitulo.Text = "REGISTRAR PROVEEDOR";
                    MensajePregunta = "¿Está seguro de registrar el Proveedor?";
                    MensajeRespuesta = "El Proveedor se registró satisfactoriamente";
                }
                else if (Modo == TypeModo.Editar)
                {
                    lblTitulo.Text = "EDITAR PROVEEDOR";
                    MensajePregunta = "¿Está seguro de editar el Proveedor?";
                    MensajeRespuesta = "El Proveedor se editó satisfactoriamente"; ;

                    ProveedoresBC objProveedorBC = new ProveedoresBC();
                    Proveedores objProveedor = objProveedorBC.ProveedoresObtener(Id);
                    txtNombre.Text = objProveedor.Nombre;
                }
                else if (Modo == TypeModo.Eliminar)
                {
                    lblTitulo.Text = "ELIMINAR PROVEEDOR";
                    MensajePregunta = "¿Está seguro de eliminar el Proveedor?";
                    MensajeRespuesta = "El Proveedor se eliminó satisfactoriamente";
                    ProveedoresBC objProveedorBC = new ProveedoresBC();
                    Proveedores objProveedor = objProveedorBC.ProveedoresObtener(Id);
                    txtNombre.Text = objProveedor.Nombre;
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

            ProveedoresBC objProveedorBC = new ProveedoresBC();
            Proveedores objProveedor = new Proveedores();
            objProveedor.Nombre = txtNombre.Text;

            if (Modo == TypeModo.Editar)
            {
                objProveedor.ProveedorId = Id;
                objProveedorBC.ProveedoresEditar(objProveedor);
            }
            else if (Modo == TypeModo.Registrar)
            {
                objProveedorBC.ProveedoresRegistrar(objProveedor);
            }
            else if (Modo == TypeModo.Eliminar)
            {
                objProveedor.ProveedorId = Id;
                objProveedorBC.ProveedoresEliminar(Id);
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
