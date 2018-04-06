using PV.DL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BC
{
   public class MarcasBC
    {
        public List<Marcas> MarcaListar()
        {
            PVEntities context = new PVEntities();

            return context.Marcas.ToList();
        }

        public List<Marcas> Busqueda(String busqueda)
        {
            PVEntities context = new PVEntities();

            return context.Marcas.Where(X => X.Descripcion.Contains(busqueda)).ToList();
        }

        public void MarcaRegistrar(Marcas objMarca)
        {
            PVEntities context = new PVEntities();

            context.Marcas.Add(objMarca);
            context.SaveChanges();
        }

        public void MarcaEditar(Marcas objMarca)
        {
            PVEntities context = new PVEntities();

            Marcas objMarcaOri = context.Marcas.FirstOrDefault(X =>
            X.MarcaId == objMarca.MarcaId);
            objMarcaOri.Nombre = objMarca.Nombre;
            objMarcaOri.Descripcion = objMarca.Descripcion;

            context.SaveChanges();
        }

        public Marcas MarcaObtener(int MarcaId)
        {
            PVEntities context = new PVEntities();

            return context.Marcas.FirstOrDefault(X => X.MarcaId == MarcaId);
        }

        public void MarcaEliminar(int MarcaId)
        {
            PVEntities context = new PVEntities();
            Marcas objMarca = context.Marcas
                .FirstOrDefault(X =>
                X.MarcaId == MarcaId);
            context.Marcas.Remove(objMarca);
            context.SaveChanges();
        }
    }
}
