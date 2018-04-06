using PV.DL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BC
{
   public class RolesBC
    {
        public List<Roles> RolesListar()
        {
            PVEntities context = new PVEntities();

            return context.Roles.ToList();
        }

        public List<Roles> Busqueda(String busqueda)
        {
            PVEntities context = new PVEntities();

            return context.Roles.Where(X => X.Descripcion.Contains(busqueda)).ToList();
        }

        public void RolesRegistrar(Roles objRoles)
        {
            PVEntities context = new PVEntities();

            context.Roles.Add(objRoles);
            context.SaveChanges();
        }

        public void RolesEditar(Roles objRoles)
        {
            PVEntities context = new PVEntities();

            Roles objRolesOri = context.Roles.FirstOrDefault(X =>
            X.RolId == objRoles.RolId);
            objRolesOri.Acronimo = objRoles.Acronimo;
            objRolesOri.Descripcion = objRoles.Descripcion;

            context.SaveChanges();
        }

        public Roles RolesObtener(int RolesId)
        {
            PVEntities context = new PVEntities();

            return context.Roles.FirstOrDefault(X =>
            X.RolId == RolesId);
        }

        public void RolesEliminar(int RolesId)
        {
            PVEntities context = new PVEntities();
            Roles objRoles = context.Roles
                .FirstOrDefault(X =>
                X.RolId == RolesId);
            context.Roles.Remove(objRoles);
            context.SaveChanges();
        }
    }
}
