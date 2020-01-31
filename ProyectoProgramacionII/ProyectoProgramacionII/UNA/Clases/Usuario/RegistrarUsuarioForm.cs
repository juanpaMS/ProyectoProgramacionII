using Biblioteca.Biblioteca.Clases;
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
        //int ixP = 0;

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
                MySQLAccess mySQL = new MySQLAccess();
                try
                {
                    mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";
                    var connection = mySQL.GetConnection();
                    mySQL.OpenConnection();
                    if (mySQL.InsertarUsuario(UsuarioRegistrarTextBox.Text, ContrasenaRegistrarTextBox.Text))
                    {

                        this.Hide();
                    }
                    else MessageBox.Show("No se ha Registrado");
                }
                catch
                {
                    mySQL.RollBackTransaction();
                }
                finally
                {
                    mySQL.CloseConnection();
                }
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
