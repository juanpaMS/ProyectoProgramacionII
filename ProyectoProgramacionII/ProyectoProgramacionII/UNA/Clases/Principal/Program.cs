using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacionII
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //IniciarSesionUsuarioForm formulario = new IniciarSesionUsuarioForm();
            //LibroForm frm = new LibroForm();
            PrincipalForm form = new PrincipalForm();
            Application.Run(form);
        }
    }
}
