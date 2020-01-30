using Biblioteca.Biblioteca.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacionII.UNA.Clases.Usuario
{
    public partial class CambiarContraseñaForm : Form
    {
        public CambiarContraseñaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NuevaContraseñaTextBox.Text != "")
            {
                MysqlAccess mySQL = new MysqlAccess();
                mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";




                try
                {
                    mySQL.OpenConnection();

                    int filasAfectadas = 0;
                    var connection = mySQL.GetConnection();

                    
                      MySqlCommand cmd = connection.CreateCommand();
                      cmd.CommandType = CommandType.Text;
                      cmd.CommandText = "update Usuario set contraseña ='" + NuevaContraseñaTextBox.Text + "' ";
                      cmd.BeginExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                    ad.Fill(dt);
                    filasAfectadas = Convert.ToInt32(dt.Rows.Count.ToString());
                    
                    if (filasAfectadas == 0)
                    {
                        MessageBox.Show("Datos no editados");
                    }
                    else
                    {
                        PrincipalForm principal = new PrincipalForm();
                        principal.Show();
                    }

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
    }
}
