using System;
using System.Collections.Generic;
using System.Linq;
using PV.DL.DataModel;
using System.Data.Entity.Core.Objects;

namespace PV.BC
{

    public class UsuariosBC
    {
        public Usuarios ValidarUsuarios(String usuario, String contraseña)
        {
            PVEntities contex = new PVEntities();
            return contex.Usuarios.FirstOrDefault(X => X.Usuario == usuario &&
            X.Contraseña == contraseña);


        }
        public List<Usuarios> UsuariosListar()
        {
            PVEntities context = new PVEntities();

            return context.Usuarios.ToList();
        }

        public List<Usuarios> Busqueda(String busqueda)
        {
            PVEntities context = new PVEntities();

            return context.Usuarios.Where(X => X.Nombre.Contains(busqueda)).ToList();
        }

        public void UsuariosRegistrar(Usuarios objUsuarios)
        {
            PVEntities context = new PVEntities();

            context.Usuarios.Add(objUsuarios);
            context.SaveChanges();
        }

        public void UsuariosEditar(Usuarios objUsuarios)
        {
            PVEntities context = new PVEntities();

            Usuarios objUsuariosOri = context.Usuarios.FirstOrDefault(X =>
            X.UsuarioId == objUsuarios.UsuarioId);
            objUsuariosOri.Nombre = objUsuarios.Nombre;
            objUsuariosOri.Paterno = objUsuarios.Paterno;
            objUsuariosOri.Materno = objUsuarios.Materno;
            objUsuariosOri.RolId = objUsuarios.RolId;
            objUsuariosOri.Usuario = objUsuarios.Usuario;
            objUsuariosOri.Contraseña = objUsuarios.Contraseña;

            context.SaveChanges();
        }

        public Usuarios UsuariosObtener(int UsuariosId)
        {
            PVEntities context = new PVEntities();

            return context.Usuarios.FirstOrDefault(X =>
            X.UsuarioId == UsuariosId);
        }

        public void UsuariosEliminar(int UsuariosId)
        {
            PVEntities context = new PVEntities();
            Usuarios objUsuarios = context.Usuarios
                .FirstOrDefault(X =>
                X.UsuarioId == UsuariosId);
            context.Usuarios.Remove(objUsuarios);
            context.SaveChanges();
        }

        public Object ProcedureUsuario()
        {
            PVEntities context = new PVEntities();

            return context.ProcedureUsuario();
        }

        
        public Object BusquedaUsuario(String Busqueda)
        {
            PVEntities context = new PVEntities();

            return context.BusquedaProcedureUsuario();
        }  
    }
}