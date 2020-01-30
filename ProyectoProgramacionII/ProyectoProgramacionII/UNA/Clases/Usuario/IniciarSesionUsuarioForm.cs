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
        Usuario persona = new Usuario();

        public IniciarSesionUsuarioForm()
        {
            InitializeComponent();
        }

        private void IniciarSesionForm_Load(object sender, EventArgs e)
        {

        }

        public Usuario ObtenerUsuario()
        {
            return persona;
        }



        private void IngresarButton_Click(object sender, EventArgs e)
        {
            if(UsuarioTextBox.TextLength == 0)
            {
                UsuarioErrorProvider.SetError(UsuarioTextBox, "Porfavor Ingrese un nombre de usuario válido");
            }
            if(ContrasenaTextBox.TextLength == 0)
            {
                UsuarioErrorProvider.SetError(ContrasenaTextBox,"Porfavor ingrese una contraseña válida");
            }
            else
            {



                MysqlAccess mySQL = new MysqlAccess();
                mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";

                mySQL.OpenConnection();

                int i = 0;
                var connection = mySQL.GetConnection();
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Usuario where nombre ='" + UsuarioTextBox.Text + "' and contraseña = '" + ContrasenaTextBox.Text + "' ";
                cmd.BeginExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                connection.Close();
                if (i == 0)
                {
                    MessageBox.Show("Datos no encontrados");

                }
                else
                {
                    PrincipalForm principal = new PrincipalForm();
                    principal.Show();
                }



                /*
                MysqlAccess mySQL = new MysqlAccess();
                mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";

                

                conexion.Open();

                MySqlCommand cmd = conexion.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from login where username = '" + UsuarioTextBox.Text + "' and password = '" + ContrasenaTextBox.Text + "'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                int i = 0;
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0) UsuarioErrorProvider.SetError(UsuarioTextBox, "Ingrese datos válidos..");
                else
                {
                    this.Hide();
                    PrincipalForm frm = new PrincipalForm();
                    frm.Show();
                }

                conexion.Close();

    */


            }
        }

        private bool SalirDelInicio()
        {
            return MessageBox.Show("No se ha guardado la información", "¿Realmente desea salir?", MessageBoxButtons.YesNo) == DialogResult.No;
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
            if(persona.Validar(UsuarioTextBox.Text, ContrasenaTextBox.Text) == false)
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
