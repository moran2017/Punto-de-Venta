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
    public partial class frmProductos : Form
    {
        public int Id { get; set; }
        public enum TypeModo { Registrar, Editar, Eliminar }
        public TypeModo Modo { get; set; }
        public delegate void ActualizarDatos();
        public ActualizarDatos objDelegado;
        private String MensajePregunta;
        private String MensajeRespuesta;

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Estas seguro que deseas salir ?",
                   this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (!(dialog == DialogResult.Yes))
            {
                e.Cancel = true;
            }
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modo == TypeModo.Registrar)
                {
                    lblTitulo.Text = "REGISTRAR PRODUCTO";
                    MensajePregunta = "¿Está seguro de registrar el Producto?";
                    MensajeRespuesta = "El Producto se registró satisfactoriamente";

                    TipoProductosBC objTipoProductosBC = new TipoProductosBC();

                    cbTipoProducto.DataSource = objTipoProductosBC.TipoProductosListar();
                    cbTipoProducto.DisplayMember = "Nombre";
                    cbTipoProducto.ValueMember = "TipoProductoId";

                    MarcasBC objMarcaBC = new MarcasBC();
                  
                    cbMarca.DataSource = objMarcaBC.MarcaListar();
                    cbMarca.DisplayMember = "Nombre";
                    cbMarca.ValueMember = "MarcaId";  
                }
                else if (Modo == TypeModo.Editar)
                {
                    lblTitulo.Text = "EDITAR PRODUCTO";
                    MensajePregunta = "¿Está seguro de editar el Producto?";
                    MensajeRespuesta = "El Producto se editó satisfactoriamente"; ;

                    ProductosBC objProductoBC = new ProductosBC();
                    Productos objProducto = objProductoBC.ProductosObtener(Id);
                    TipoProductosBC objTipoProductosBC = new TipoProductosBC();

                    cbTipoProducto.DataSource = objTipoProductosBC.TipoProductosListar();
                    cbTipoProducto.DisplayMember = "Nombre";
                    cbTipoProducto.ValueMember = "TipoProductoId";

                    MarcasBC objMarcaBC = new MarcasBC();
                    cbMarca.DataSource = objMarcaBC.MarcaListar();
                    cbMarca.DisplayMember = "Nombre";
                    cbMarca.ValueMember = "MarcaId";

                    txtNombre.Text = objProducto.Nombre.ToString();
                    txtPrecioCompra.Text = Convert.ToString(objProducto.PrecioCompra);
                    txtPrecioVenta.Text = Convert.ToString(objProducto.PrecioVenta);
                    txtCodigo.Text = objProducto.Codigo.ToString();

                }
                else if (Modo == TypeModo.Eliminar)
                {
                    lblTitulo.Text = "ELIMINAR PRODUCTO";
                    MensajePregunta = "¿Está seguro de eliminar el Producto?";
                    MensajeRespuesta = "El Producto se elimino satisfactoriamente";

                    ProductosBC objProductoBC = new ProductosBC();
                    Productos objProducto = objProductoBC.ProductosObtener(Id);
                    TipoProductosBC objTipoProductosBC = new TipoProductosBC();

                    cbTipoProducto.DataSource = objTipoProductosBC.TipoProductosListar();
                    cbTipoProducto.DisplayMember = "Nombre";
                    cbTipoProducto.ValueMember = "TipoProductoId";
                    cbTipoProducto.SelectedItem = Id;

                    MarcasBC objMarcaBC = new MarcasBC();
                    cbMarca.DataSource = objMarcaBC.MarcaListar();
                    cbMarca.DisplayMember = "Nombre";
                    cbMarca.ValueMember = "MarcaId";
                    cbMarca.SelectedItem = Id;

                    txtNombre.Text = objProducto.Nombre.ToString();
                    txtPrecioCompra.Text = Convert.ToString(objProducto.PrecioCompra);
                    txtPrecioVenta.Text = Convert.ToString(objProducto.PrecioVenta);
                    txtCodigo.Text = objProducto.Codigo.ToString();
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

            ProductosBC objProductoBC = new ProductosBC();
            Productos objProducto = new Productos();

            objProducto.TipoProductoId = Convert.ToInt32(cbTipoProducto.SelectedValue.ToString());
            lblPrueba.Text = objProducto.TipoProductoId.ToString();
            objProducto.MarcaId = Convert.ToInt32(cbMarca.SelectedValue.ToString());
            objProducto.Nombre = txtNombre.Text;
            objProducto.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            objProducto.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            objProducto.Codigo = txtCodigo.Text;


            if (Modo == TypeModo.Editar)
            {
                objProducto.ProductoId = Id;
                objProductoBC.ProductosEditar(objProducto);
            }
            else if (Modo == TypeModo.Registrar)
            {
                objProductoBC.ProductosRegistrar(objProducto);
            }
            else if (Modo == TypeModo.Eliminar)
            {
                objProducto.ProductoId = Id;
                objProductoBC.ProductosEliminar(Id);
            }
            objDelegado();
            MessageBox.Show(MensajeRespuesta, this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {
           // txtPrecioCompra.Text = string.Format("#,###.##");
        }
    }
}
