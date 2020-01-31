using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Biblioteca.Biblioteca.Clases
{
    public class MySQLAccess : DBAccess
    {
        
        public override void OpenConnection()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }
        public override void CloseConnection()
        {
            if (Connection != null)
            {
                Connection.Close();
            }
        }
        public override long EjectSQL(string sql)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(sql, (MySqlConnection)Connection);
            return mySqlCommand.ExecuteNonQuery();

        }
        public override DataTable QuerySQL(string sql)
        {
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, (MySqlConnection)Connection);
            adapter.Fill(result);
            return result;
        }
        public override Boolean IsTransaction()
        {
            return (Transaction != null);

        }
        public override void CommitTransaction()
        {
            if (IsTransaction())
            {
                Transaction.Commit();
            }
        }
        public override void RollBackTransaction()
        {
            if (IsTransaction())
            {
                Transaction.Rollback();
            }
        }
        public override void BeginTransaction()
        {
            if (Connection != null)
            {
                Transaction = Connection.BeginTransaction();
            }
        }
        public string GetHoja()
        {
           // MySqlCommand cmd = new MySqlCommand(string.Format("select * from Cuaderno where nombre like '%{0}%'", nombre), (MySqlConnection)Connection);
            return "ok"; 
        }

        private DataSet ds;//guarda varias tablas llamadas "dataTable"

        public DataTable BuscarLibro(string nombre)
        {
            MySqlCommand cmd = new MySqlCommand(string.Format("select * from Cuaderno where nombre like '%{0}%'", nombre), (MySqlConnection)Connection);

            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

            ds = new DataSet();
            ad.Fill(ds, "Table");
           
            return ds.Tables["Table"];
        }
        public DataTable BuscarNota(string nombre)
        {
            MySqlCommand cmd = new MySqlCommand(string.Format("select * from Nota where titulo like '{0}'", nombre), (MySqlConnection)Connection);

            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

            ds = new DataSet();
            ad.Fill(ds, "Table");

            return ds.Tables["Table"];
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public bool EliminarLibro(string nombre)
        {
            
            MySqlCommand cmd = new MySqlCommand(string.Format("delete from Cuaderno where nombre = '{0}'", nombre), (MySqlConnection)Connection);
            int filasAfectadas = cmd.ExecuteNonQuery();
            
            if (filasAfectadas > 0) return true;
            else return false;
        }
        public bool EliminarNota(string nombre)
        {

            MySqlCommand cmd = new MySqlCommand(string.Format("delete from Nota where titulo = '{0}'", nombre), (MySqlConnection)Connection);
            int filasAfectadas = cmd.ExecuteNonQuery();

            if (filasAfectadas > 0) return true;
            else return false;
        }

        public bool LogIn(string contraseña, string nombre)
        {

            int i = 0;
            
            MySqlCommand cmd = new MySqlCommand(string.Format("select * from Usuario where nombre like '%{0}%' and '%{1}%'", nombre, contraseña), (MySqlConnection)Connection);
            cmd.BeginExecuteNonQuery();

            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            i = Convert.ToInt32(dataTable.Rows.Count.ToString());

            if (i == 0) return false;
            else return true;
           
        }
        public bool CambioContraseña(string pass)
        {
            MySqlCommand cmd = new MySqlCommand(string.Format("update usuario set contraseña = '{0}'", pass), (MySqlConnection)Connection);
            int filasAfectadas = cmd.ExecuteNonQuery();
            if (filasAfectadas == 0) return false;
            else return true;
        }
        public bool InsertarUsuario(string nombre, string contraseña)
        {
            string id = "2";
            MySqlCommand cmd = new MySqlCommand(string.Format("insert into Usuario values ('{0}', '{1}', '{2}')", new string[] { id, nombre, contraseña }), (MySqlConnection)Connection);
            int filasAfectadas = cmd.ExecuteNonQuery();
            if (filasAfectadas > 0) return true;
            else return false;
        }
        public bool BuscarUsuario(string nombre, string contraseña)
        {
            MySqlCommand cmd = new MySqlCommand(string.Format("select * from Usuario where nombre like '%{0}%' and '%{1}%'", nombre, contraseña), (MySqlConnection)Connection);

            return true;
        }

        public DataTable MostrarDatosLibros()
        {
            
            MySqlCommand cmdL = new MySqlCommand("select * from Cuaderno", (MySqlConnection)Connection);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmdL);

            ds = new DataSet();
            ad.Fill(ds, "Table");
            
            return ds.Tables["Table"];
        }
        public DataTable MostrarDatosNota()
        {

            MySqlCommand cmdN = new MySqlCommand("select * from Nota", (MySqlConnection)Connection);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmdN);

            ds = new DataSet();
            ad.Fill(ds, "Table");

            return ds.Tables["Table"];
        }
        public DataTable mainMostrarDatosNota(string cuaderno)
        {
            //Se intenta hacer que encunetre la hoja de la nota de el cuaderno seleccionado
            MySqlCommand cmdN = new MySqlCommand(string.Format("SELECT Hoja FROM Nota WHERE nombre LIKE '{0}'", cuaderno), (MySqlConnection)Connection);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmdN);

            ds = new DataSet();
            ad.Fill(ds, "Table");

            return ds.Tables["Table"];
        }
        public string getHoja(string Nota)
        {
            MySqlCommand cmdN = new MySqlCommand(string.Format("SELECT hoja FROM '{0}'",Nota), (MySqlConnection)Connection);
            cmdN.CommandType = CommandType.Text;
            
        }

        public bool InsertarLibro(string nombre, string color, string categoria)
        {
            string idLibros = "1";
            MySqlCommand cmd = new MySqlCommand(string.Format("insert into Cuaderno values ({0}, '{1}','{2}','{3}')", new string[] {idLibros,nombre, color, categoria }), (MySqlConnection)Connection);
            int filasAfectadas = cmd.ExecuteNonQuery();
            
            if (filasAfectadas > 0) return true;
            else return false;
        }
        public bool InsertarNota(string titulo, string categoria, string privacidad, string color)
        {
            string idNotas = "2";
            string Hoja = "Hoja 1";
            MySqlCommand cmd = new MySqlCommand(string.Format("insert into Nota values ({0}, '{1}','{2}','{3}','{4}')", new string[] { idNotas, titulo, color, categoria, Hoja }), (MySqlConnection)Connection);
            int filasAfectadas = cmd.ExecuteNonQuery();
            if (filasAfectadas > 0) return true;
            else return false;
        }
    }
}
