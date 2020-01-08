using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProyectoProgramacionII
{
    public class ArchivoManager
    {

        public List<CuadernoDigital> BookList { get; set; }
        public ArchivoManager()
        {
            BookList = new List<CuadernoDigital>();
        }
        public string CrearArchivo(string rutaBase)
        {
            string path = $"{DateTime.Now.ToString()}.csv";
            path = path.Replace("/", "_");
            path = path.Replace(":", "_");

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach ( CuadernoDigital cuadernoDigital in BookList)
                {
                    var line = $"{cuadernoDigital.nombre},{cuadernoDigital.color},{cuadernoDigital.categoria}";
                    streamWriter.WriteLine(line);
                }
                streamWriter.Flush();
                return path;
            }
        }
        public void LeerArchivo()
        {

        }

    }
}