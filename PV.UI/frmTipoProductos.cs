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
    public partial class frmTipoProductos : Form
    {
        public int Id { get; set; }
        public enum TypeModo { Registrar, Editar, Eliminar }
        public TypeModo Modo { get; set; }
        public delegate void ActualizarDatos();
        public ActualizarDatos objDelegado;
        private String MensajePregunta;
        private String MensajeRespuesta;
        public frmTipoProductos()
        {
            InitializeComponent();
        }

        private void frmTipoProductos_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modo == TypeModo.Registrar)
                {
                    lblTitulo.Text = "REGISTRAR TIPO DE PRODUCTO";
                    MensajePregunta = "¿Está seguro de registrar el Tipo de Producto?";
                    MensajeRespuesta = "El Tipo de Producto se registró satisfactoriamente";

                    ProveedoresBC objProveedorBC = new ProveedoresBC();

                    cbProveedor.DataSource = objProveedorBC.ProveedoresListar();
                    cbProveedor.DisplayMember = "Nombre";
                    cbProveedor.ValueMember = "ProveedorId";

                }
                else if (Modo == TypeModo.Editar)
                {
                    lblTitulo.Text = "EDITAR TIPO DE PRODUCTO";
                    MensajePregunta = "¿Está seguro de editar el Tipo de Producto??";
                    MensajeRespuesta = "El Tipo de Producto se editó satisfactoriamente"; ;

                    TipoProductosBC objTipoProductoBC = new TipoProductosBC();
                    TipoProductos objTipoProducto = objTipoProductoBC.TipoProductosObtener(Id);
                    ProveedoresBC objProveedorBC = new ProveedoresBC();
                    Proveedores objProveedor = new Proveedores();

                    txtNombre.Text = (String.Format(objTipoProducto.Nombre.
                        ToString()));
                    cbProveedor.DataSource = objProveedorBC.ProveedoresListar();
                    cbProveedor.DisplayMember = "Nombre";
                    cbProveedor.ValueMember = "ProveedorId";
                    txtDescripcion.Text = (String.Format(objTipoProducto.Descripcion.
                        ToString()));
                }
                else if (Modo == TypeModo.Eliminar)
                {
                    lblTitulo.Text = "ELIMINAR TIPO DE PRODUCTO";
                    MensajePregunta = "¿Está seguro de eliminar el Tipo de Pago??";
                    MensajeRespuesta = "El Tipo de Producto se elimino satisfactoriamente";

                    TipoProductosBC objTipoProductoBC = new TipoProductosBC();
                    TipoProductos objTipoProducto = objTipoProductoBC.TipoProductosObtener(Id);
                    ProveedoresBC objProveedorBC = new ProveedoresBC();
                    Proveedores objProveedor = new Proveedores();

                    txtNombre.Text = (String.Format(objTipoProducto.Nombre.
                        ToString()));
                    cbProveedor.DataSource = objProveedorBC.ProveedoresListar();
                    cbProveedor.DisplayMember = "Nombre";
                    cbProveedor.ValueMember = "ProveedorId";
                    txtDescripcion.Text = (String.Format(objTipoProducto.Descripcion.
                        ToString()));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el sistema, por favor intente más tarde.", this.Text,
                  MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmTipoProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Estas seguro que deseas salir ?",
               this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(dialog == DialogResult.Yes))
            {
                e.Cancel = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(MensajePregunta, this.Text,
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
              DialogResult.Yes)
                return;

            TipoProductosBC objTipoProductosBC = new TipoProductosBC();
            TipoProductos objTipoProducto = new TipoProductos();

            objTipoProducto.Nombre = txtNombre.Text;
            objTipoProducto.ProveedorId = Convert.ToInt32(cbProveedor.SelectedValue.
                ToString());
            objTipoProducto.Descripcion = txtDescripcion.Text;

            if (Modo == TypeModo.Editar)
            {
                objTipoProducto.TipoProductoId = Id;
                objTipoProductosBC.TipoProductosEditar(objTipoProducto);
            }
            else if (Modo == TypeModo.Registrar)
            {
                objTipoProductosBC.TipoProductosRegistrar(objTipoProducto);
            }
            else if (Modo == TypeModo.Eliminar)
            {
                objTipoProducto.TipoProductoId = Id;
                objTipoProductosBC.TipoProductosEliminar(Id);
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
