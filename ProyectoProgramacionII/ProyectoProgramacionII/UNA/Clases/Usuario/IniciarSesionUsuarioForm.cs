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
                mySQL.BeginTransaction();
                // mySQL.EjectSQL("select * usuario where nombre like '%{0}%'", UsuarioTextBox.Text);

                mySQL.Buscar(UsuarioTextBox.Text);


                mySQL.CloseConnection();




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
    }
}
