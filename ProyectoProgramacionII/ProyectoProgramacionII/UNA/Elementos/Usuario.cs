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
            get => default;
            set
            {
            }
        }

        public bool Validar(string nom, string con)
        {
            if(nom == "admin" && con == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string contraseña
        {
            get => default;
            set
            {
            }
        }
    }
}