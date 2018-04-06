using PV.DL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BC
{
    public class TipoPagosBC
    {
        public List<TipoPagos> TipoPagosListar()
        {
            PVEntities context = new PVEntities();

            return context.TipoPagos.ToList();
        }

        public List<TipoPagos> Busqueda(String busqueda)
        {
            PVEntities context = new PVEntities();

            return context.TipoPagos.Where(X => X.Descripcion.Contains(busqueda)).ToList();
        }

        public void TipoPagosRegistrar(TipoPagos objTipoPagos)
        {
            PVEntities context = new PVEntities();

            context.TipoPagos.Add(objTipoPagos);
            context.SaveChanges();
        }

        public void TipoPagosEditar(TipoPagos objTipoPagos)
        {
            PVEntities context = new PVEntities();

            TipoPagos objTipoPagosOri = context.TipoPagos.FirstOrDefault(X =>
            X.TipoPagoId == objTipoPagos.TipoPagoId);
            objTipoPagosOri.Acronimo = objTipoPagos.Acronimo;
            objTipoPagosOri.Descripcion = objTipoPagos.Descripcion;

            context.SaveChanges();
        }

        public TipoPagos TipoPagosObtener(int TipoPagosId)
        {
            PVEntities context = new PVEntities();

            return context.TipoPagos.FirstOrDefault(X =>
            X.TipoPagoId == TipoPagosId);
        }

        public void TipoPagosEliminar(int TipoPagosId)
        {
            PVEntities context = new PVEntities();
            TipoPagos objTipoPagos = context.TipoPagos
                .FirstOrDefault(X =>
                X.TipoPagoId == TipoPagosId);
            context.TipoPagos.Remove(objTipoPagos);
            context.SaveChanges();
        }
    }
}
