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

        public bool Validar(string nom, string con)
        {
            if(nom == "admin" && con == "admin")    //DATOS DE LOGEO
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
            get;
            set;
        }
    }
}