using PV.DL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BC
{
    public class ProveedoresBC
    {
        public List<Proveedores> ProveedoresListar()
        {
            PVEntities context = new PVEntities();

            return context.Proveedores.ToList();
        }

        public List<Proveedores> Busqueda(String busqueda)
        {
            PVEntities context = new PVEntities();

            return context.Proveedores.Where(X => X.Nombre.Contains(busqueda)).ToList();
        }

        public void ProveedoresRegistrar(Proveedores objProveedores)
        {
            PVEntities context = new PVEntities();

            context.Proveedores.Add(objProveedores);
            context.SaveChanges();
        }

        public void ProveedoresEditar(Proveedores objProveedores)
        {
            PVEntities context = new PVEntities();

            Proveedores objProveedoresOri = context.Proveedores.FirstOrDefault(X =>
            X.ProveedorId == objProveedores.ProveedorId);
            objProveedoresOri.Nombre = objProveedores.Nombre;

            context.SaveChanges();
        }

        public Proveedores ProveedoresObtener(int ProveedoresId)
        {
            PVEntities context = new PVEntities();

            return context.Proveedores.FirstOrDefault(X =>
            X.ProveedorId == ProveedoresId);
        }

        public void ProveedoresEliminar(int ProveedoresId)
        {
            PVEntities context = new PVEntities();
            Proveedores objProveedores = context.Proveedores
                .FirstOrDefault(X =>
                X.ProveedorId == ProveedoresId);
            context.Proveedores.Remove(objProveedores);
            context.SaveChanges();
        }
    }
}
