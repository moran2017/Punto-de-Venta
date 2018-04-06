using PV.DL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BC
{
   public class TipoProductosBC
    {
        public List<TipoProductos> TipoProductosListar()
        {
            PVEntities context = new PVEntities();

            return context.TipoProductos.ToList();
        }

        public List<TipoProductos> Busqueda(String busqueda)
        {
            PVEntities context = new PVEntities();

            return context.TipoProductos.Where(X => X.Nombre.Contains(busqueda)).ToList();
        }

        public void TipoProductosRegistrar(TipoProductos objTipoProductos)
        {
            PVEntities context = new PVEntities();

            context.TipoProductos.Add(objTipoProductos);
            context.SaveChanges();
        }

        public void TipoProductosEditar(TipoProductos objTipoProductos)
        {
            PVEntities context = new PVEntities();

            TipoProductos objTipoProductosOri = context.TipoProductos.FirstOrDefault(X =>
            X.TipoProductoId == objTipoProductos.TipoProductoId);
            objTipoProductosOri.Nombre = objTipoProductos.Nombre;
            objTipoProductosOri.ProveedorId = objTipoProductos.ProveedorId;
            objTipoProductosOri.Descripcion = objTipoProductos.Descripcion;

            context.SaveChanges();
        }

        public TipoProductos TipoProductosObtener(int TipoProductosId)
        {
            PVEntities context = new PVEntities();

            return context.TipoProductos.FirstOrDefault(X =>
            X.TipoProductoId == TipoProductosId);
        }

        public void TipoProductosEliminar(int TipoProductosId)
        {
            PVEntities context = new PVEntities();
            TipoProductos objTipoProductos = context.TipoProductos
                .FirstOrDefault(X =>
                X.TipoProductoId == TipoProductosId);
            context.TipoProductos.Remove(objTipoProductos);
            context.SaveChanges();
        }
    }
}
