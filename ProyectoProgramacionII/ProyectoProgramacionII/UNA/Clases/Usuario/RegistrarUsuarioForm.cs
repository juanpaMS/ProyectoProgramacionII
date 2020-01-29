using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacionII
{
    public partial class RegistrarUsuarioForm : Form
    {

        Usuario[] personasVec = new Usuario[100];
        int ixP = 0;

        public RegistrarUsuarioForm()
        {
            InitializeComponent();
        }

        private void RegistrarForm_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            if (InformacionRegistroEsValida())
            {
                Usuario persona = RellenarRegistro();
                personasVec[ixP] = persona;
                ixP += 1;
            }
        }

        private Usuario RellenarRegistro()
        {
            return new Usuario
            {
                Nombre = UsuarioRegistrarTextBox.Text,
                Contraseña = ContrasenaRegistrarTextBox.Text,
            };
        }

        private bool InformacionRegistroEsValida()
        {
            bool esValida = true;
            if(UsuarioRegistrarTextBox.Text == "")
            {
                esValida = false;
                RegistroErrorProvider.SetError(UsuarioRegistrarTextBox, "Debe digitar un Nombre");
            }
            if (ContrasenaRegistrarTextBox.Text == "")
            {
                esValida = false;
                RegistroErrorProvider.SetError(ContrasenaRegistrarTextBox, "Debe digitar una Contraseña");
            }
            return esValida;
        }
    }
}
