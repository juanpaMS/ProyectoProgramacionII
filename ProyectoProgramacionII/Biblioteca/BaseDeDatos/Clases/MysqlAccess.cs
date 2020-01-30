using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Biblioteca.Biblioteca.Clases
{
    public class MysqlAccess : DBAccess
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
        private DataSet ds;//guarda varias tablas llamadas "dataTable"

        public DataTable BuscarLibro(string nombre)
        {
            MySqlCommand cmd = new MySqlCommand(string.Format("select * from Cuaderno where nombre like '%{0}%'", nombre), (MySqlConnection)Connection);

            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

            ds = new DataSet();
            ad.Fill(ds, "Table");
           
            return ds.Tables["Table"];
        }
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public bool Eliminar(string nombre)
        {
            
            MySqlCommand cmd = new MySqlCommand(string.Format("delete from Cuaderno where nombre = '{0}'", nombre), (MySqlConnection)Connection);
            int filasAfectadas = cmd.ExecuteNonQuery();
            
            if (filasAfectadas > 0) return true;
            else return false;
        }
        public bool InsertarUsuario(string nombre, string contraseña)
        {
            string id = "2";
            MySqlCommand cmd = new MySqlCommand(string.Format("insert into Usuario values ('{0}', '{1}', '({2})')", new string[] { id, nombre, contraseña }), (MySqlConnection)Connection);
            int filasAfectadas = cmd.ExecuteNonQuery();
            if (filasAfectadas > 0) return true;
            else return false;
        }
        public bool BuscarUsuario(string nombre, string contraseña)
        {
            MySqlCommand cmd = new MySqlCommand(string.Format("select * from Usuario where nombre like '%{0}%' and '%{1}%'", nombre, contraseña), (MySqlConnection)Connection);

            return true;
        }

        public DataTable MostrarDatos()
        {
            
            MySqlCommand cmd = new MySqlCommand("select * from Cuaderno", (MySqlConnection)Connection);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

            ds = new DataSet();
            ad.Fill(ds, "Table");
            
            return ds.Tables["Table"];
        }

        public bool Insertar(string nombre, string color, string categoria)
        {
            string id = "2";
            MySqlCommand cmd = new MySqlCommand(string.Format("insert into Cuaderno values ({0}, '{1}','{2}','{3}')", new string[] {id,nombre, color, categoria }), (MySqlConnection)Connection);
            int filasAfectadas = cmd.ExecuteNonQuery();
            
            if (filasAfectadas > 0) return true;
            else return false;
        }
    }
}
