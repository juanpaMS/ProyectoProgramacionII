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
                MySQLAccess mySQL = new MySQLAccess();
                mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";




                try
                {
                    mySQL.OpenConnection();

                    var conexion = mySQL.GetConnection();

                    if (mySQL.CambioContraseña(NuevaContraseñaTextBox.Text))
                    {
                        PrincipalForm principal = new PrincipalForm();
                        principal.Show();
                    }else MessageBox.Show("Datos no editados");

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

        private void CambiarContraseñaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
