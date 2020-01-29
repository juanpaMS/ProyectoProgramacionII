using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoProgramacionII
{
    public class CuadernoDigital
    {
        public string nombre
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

        public int orden
        {
            get;
            set;
        }

        public Nota Nota
        {
            get => default;
            set
            {
            }
        }
    }
}