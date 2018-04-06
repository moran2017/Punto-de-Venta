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
    public partial class frmTipoPagos : Form
    {
        public int Id { get; set; }
        public enum TypeModo { Registrar, Editar, Eliminar }
        public TypeModo Modo { get; set; }
        public delegate void ActualizarDatos();
        public ActualizarDatos objDelegado;
        private String MensajePregunta;
        private String MensajeRespuesta;

        public frmTipoPagos()
        {
            InitializeComponent();
        }

        private void frmTipoPagos_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modo == TypeModo.Registrar)
                {
                    lblTitulo.Text = "REGISTRAR TIPO DE PAGO";
                    MensajePregunta = "¿Está seguro de registrar el Tipo Pagos?";
                    MensajeRespuesta = "El Tipo Pagos se registró satisfactoriamente";
                }
                else if (Modo == TypeModo.Editar)
                {
                    lblTitulo.Text = "EDITAR TIPOS DE PAGO";
                    MensajePregunta = "¿Está seguro de editar el Tipo Pagos?";
                    MensajeRespuesta = "El TipoPagos se editó satisfactoriamente"; ;

                    TipoPagosBC objTipoPagosBC = new TipoPagosBC();
                    TipoPagos objTipoPagos = objTipoPagosBC.TipoPagosObtener(Id);
                    txtAcronimo.Text = objTipoPagos.Acronimo;
                    txtDescipcion.Text = objTipoPagos.Descripcion;
                }
                else if (Modo == TypeModo.Eliminar)
                {
                    lblTitulo.Text = "ELIMINAR TIPOS DE PAGO";
                    MensajePregunta = "¿Está seguro de eliminar el Tipo Pagos?";
                    MensajeRespuesta = "El Tipo Pagos se eliminó satisfactoriamente";
                    TipoPagosBC objTipoPagosBC = new TipoPagosBC();
                    TipoPagos objTipoPagos = objTipoPagosBC.TipoPagosObtener(Id);
                    txtAcronimo.Text = objTipoPagos.Acronimo;
                    txtDescipcion.Text = objTipoPagos.Descripcion;
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

            TipoPagosBC objTipoPagosBC = new TipoPagosBC();
            TipoPagos objTipoPagos = new TipoPagos();
            objTipoPagos.Acronimo = txtAcronimo.Text;
            objTipoPagos.Descripcion = txtDescipcion.Text;

            if (Modo == TypeModo.Editar)
            {
                objTipoPagos.TipoPagoId = Id;
                objTipoPagosBC.TipoPagosEditar(objTipoPagos);
            }
            else if (Modo == TypeModo.Registrar)
            {
                objTipoPagosBC.TipoPagosRegistrar(objTipoPagos);
            }
            else if (Modo == TypeModo.Eliminar)
            {
                objTipoPagos.TipoPagoId = Id;
                objTipoPagosBC.TipoPagosEliminar(Id);
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
