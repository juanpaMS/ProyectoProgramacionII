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
    }
}
