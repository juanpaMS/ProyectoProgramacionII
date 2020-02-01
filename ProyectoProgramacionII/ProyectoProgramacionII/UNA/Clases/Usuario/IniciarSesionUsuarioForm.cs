using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Biblioteca.Clases;
using MongoDB.Driver.Core.Configuration;
using MySql.Data.MySqlClient;
using ProyectoProgramacionII.UNA.Clases.Usuario;

namespace ProyectoProgramacionII
{
    public partial class IniciarSesionUsuarioForm : Form
    {
        Usuario usuario = new Usuario();

        public IniciarSesionUsuarioForm()
        {
            InitializeComponent();
        }

        private void IniciarSesionForm_Load(object sender, EventArgs e)
        {
            
        }

        public Usuario ObtenerUsuario()
        {
            return usuario;
        }



        private void IngresarButton_Click(object sender, EventArgs e)
        {
            if(UsuarioTextBox.TextLength < 3)
            {
                UsuarioErrorProvider.SetError(UsuarioTextBox, "Porfavor Ingrese un nombre de usuario válido (más de 3 caracteres)");
            }
            if(ContrasenaTextBox.TextLength < 3)
            {
                UsuarioErrorProvider.SetError(ContrasenaTextBox, "Porfavor ingrese una contraseña válida (más de 3 caracteres)");
            }
            else
            {

                MySQLAccess mySQL = new MySQLAccess();
                try
                {
                    
                    mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";
                    mySQL.OpenConnection();

                    if (mySQL.LogIn(ContrasenaTextBox.Text, UsuarioTextBox.Text))
                    {
                        
                        PrincipalForm frm = new PrincipalForm();
                        frm.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Datos NO encontrados");

                    mySQL.CommitTransaction();
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

        private void IniciarSesionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            UsuarioTextBox.Text = "";
            ContrasenaTextBox.Text = "";
            Close();
            if(usuario.Validar(UsuarioTextBox.Text, ContrasenaTextBox.Text) == false)
            {
                Application.Exit();
            }
        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            RegistrarUsuarioForm registroUsuario = new RegistrarUsuarioForm();
            registroUsuario.Show();
        }

        private void CambiarContraseñaButton_Click(object sender, EventArgs e)
        {
            CambiarContraseñaForm frm = new CambiarContraseñaForm();
            frm.Show();
        }
    }
}
