using PV.DL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BC
{
   public class ProductosBC
    {
        public List<Productos> ProductosListar()
        {
            PVEntities context = new PVEntities();

            return context.Productos.ToList();
        }

        public List<Productos> Busqueda(String busqueda)
        {
            PVEntities context = new PVEntities();

            return context.Productos.Where(X => X.Nombre.Contains(busqueda)).ToList();
        }

        public void ProductosRegistrar(Productos objProductos)
        {
            PVEntities context = new PVEntities();

            context.Productos.Add(objProductos);
            context.SaveChanges();
        }

        public void ProductosEditar(Productos objProductos)
        {
            PVEntities context = new PVEntities();

            Productos objProductosOri = context.Productos.FirstOrDefault(X =>
            X.ProductoId == objProductos.ProductoId);
            objProductosOri.ProductoId = objProductos.ProductoId;
            objProductosOri.TipoProductoId = objProductos.TipoProductoId;
            objProductosOri.MarcaId = objProductos.MarcaId;
            objProductosOri.Nombre = objProductos.Nombre;
            objProductosOri.PrecioCompra = objProductos.PrecioCompra;
            objProductosOri.PrecioVenta = objProductos.PrecioVenta;
            objProductosOri.Codigo = objProductos.Codigo;

            context.SaveChanges();
        }

        public Productos ProductosObtener(int ProductosId)
        {
            PVEntities context = new PVEntities();

            return context.Productos.FirstOrDefault(X =>
            X.ProductoId == ProductosId);
        }

        public void ProductosEliminar(int ProductosId)
        {
            PVEntities context = new PVEntities();
            Productos objProductos = context.Productos
                .FirstOrDefault(X =>
                X.ProductoId == ProductosId);
            context.Productos.Remove(objProductos);
            context.SaveChanges();
        }
    }
}
