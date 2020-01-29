using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoProgramacionII
{
    public class Nota
    {
        public string titulo
        {
            get;
            set;
        }

        public string privacidad
        {
            get;
            set;
        }

        public string categoria
        {
            get;
            set;
        }

        public string color
        {
            get;
            set;
        }

        public string fuente
        {
            get;
            set;
        }

        public string letraColor
        {
            get;
            set;
        }

        public int fechaDeCreacion
        {
            get;
            set;
        }

        public DateTime fechaDeModificacion
        {
            get;
            set;
        }

        public string hoja
        {
            get => default;
            set
            {
            }
        }

        public int indice
        {
            get => default;
            set
            {
            }
        }
    }
}