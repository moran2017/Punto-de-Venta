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
using PV.BC;

namespace PV.UI
{
    public partial class frmMarcas : Form
    {
        public int Id { get; set; }
        public enum TypeModo { Registrar, Editar, Eliminar }
        public TypeModo Modo { get; set; }
        public delegate void ActualizarDatos();
        public ActualizarDatos objDelegado;
        private String MensajePregunta;
        private String MensajeRespuesta;
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(MensajePregunta, this.Text,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
               DialogResult.Yes)
                return;

            MarcasBC objMarcaBC = new MarcasBC();
            Marcas objMarca = new Marcas();
            objMarca.Nombre = txtNombre.Text;
            objMarca.Descripcion = txtDescripcion.Text;

            if (Modo == TypeModo.Editar)
            {
                objMarca.MarcaId = Id;
                objMarcaBC.MarcaEditar(objMarca);
            }
            else if (Modo == TypeModo.Registrar)
            {
                objMarcaBC.MarcaRegistrar(objMarca);
            }
            else if (Modo == TypeModo.Eliminar)
            {
                objMarca.MarcaId = Id;
                objMarcaBC.MarcaEliminar(Id);
            }
            objDelegado();
            MessageBox.Show(MensajeRespuesta, this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modo == TypeModo.Registrar)
                {
                    lblTitulo.Text = "REGISTRAR MARCA";
                    MensajePregunta = "¿Está seguro de registrar la Marca?";
                    MensajeRespuesta = "La Marca se registró satisfactoriamente";
                }
                else if (Modo == TypeModo.Editar)
                {
                    lblTitulo.Text = "EDITAR MARCA";
                    MensajePregunta = "¿Está seguro de editar la Marca?";
                    MensajeRespuesta = "La Marca se registró satisfactoriamente";

                    MarcasBC objMarcaBC = new MarcasBC();

                    Marcas objMarca = objMarcaBC.MarcaObtener(Id);
                    txtNombre.Text = objMarca.Nombre;
                    txtDescripcion.Text = objMarca.Descripcion;
                }
                else if (Modo == TypeModo.Eliminar)
                {
                    lblTitulo.Text = "ELIMINAR MARCA";
                    MensajePregunta = "¿Está seguro de eliminar la Marca?";
                    MensajeRespuesta = "La Marca se registró satisfactoriamente";
                    MarcasBC objMarcarBC = new MarcasBC();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema, por favor intente más tarde.\n" +
                ex.Message.ToString(), this.Text,
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMarcas_FormClosing(object sender, FormClosingEventArgs e)
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
