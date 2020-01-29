using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoProgramacionII
{
    public class Usuario
    {
        public string Nombre
        {
            get;
            set;
        }

        public string Contraseña
        {
            get;
            set;
        }

        public bool Validar(string nombre, string contrasena)
        {
            if (nombre == "admin" && contrasena == "admin")    //DATOS DE LOGUEO
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuario RegistrarNuevoUsuario()
        {
            Usuario usuario = new Usuario();
            return usuario;
        }
    }
}