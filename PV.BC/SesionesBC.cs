using PV.DL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BC
{
   public class SesionesBC
    {
        public List<Sesiones> SesionesListar()
        {
            PVEntities context = new PVEntities();

            return context.Sesiones.ToList();
        }

        public List<Sesiones> Busqueda(String busqueda)
        {
            PVEntities context = new PVEntities();

            return context.Sesiones.Where(X => X.Usuarios.Nombre.Contains(busqueda)).ToList();
        }

        public void SesionesRegistrar(Sesiones objSesiones)
        {
            PVEntities context = new PVEntities();

            context.Sesiones.Add(objSesiones);
            context.SaveChanges();
        }

        public void SesionesEditar(Sesiones objSesiones)
        {
            PVEntities context = new PVEntities();

            Sesiones objSesionesOri = context.Sesiones.FirstOrDefault(X =>
            X.SesionId == objSesiones.SesionId);
            objSesionesOri.UsuarioId = objSesiones.UsuarioId;
            objSesionesOri.RolId = objSesiones.RolId;
            objSesionesOri.Activo = objSesiones.Activo;
            objSesionesOri.FechaInicioSesion = objSesiones.FechaInicioSesion;
            objSesionesOri.FechaCierreSesion = objSesiones.FechaCierreSesion;

            context.SaveChanges();
        }

        public Sesiones SesionesObtener(int SesionesId)
        {
            PVEntities context = new PVEntities();

            return context.Sesiones.FirstOrDefault(X =>
            X.SesionId == SesionesId);
        }

        public void SesionesEliminar(int SesionesId)
        {
            PVEntities context = new PVEntities();
            Sesiones objSesiones = context.Sesiones
                .FirstOrDefault(X =>
                X.SesionId == SesionesId);
            context.Sesiones.Remove(objSesiones);
            context.SaveChanges();
        }
    }
}
