using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoProgramacionII
{
    public class Usuario
    {
        public string nombre
        {
            get;
            set;
        }

        public string contraseña
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

        public Usuario CrearNuevoUsuario()
        {
            Usuario nPersonas = new Usuario();
            return nPersonas;
        }
    }
}