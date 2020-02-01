using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Biblioteca.Biblioteca.Clases
{
    public abstract class DBAccess
    {
        public string ConnectionString { set; get; }
        public IDbTransaction Transaction { set; get; }
        public IDbConnection Connection { set; get; }
        public int IndiceLibros { set; get; }

        public int IndiceNotas { set; get; }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public abstract long EjectSQL(string a);
        public abstract DataTable QuerySQL(string b);
        public abstract Boolean IsTransaction();
        public abstract void CommitTransaction();
        public abstract void RollBackTransaction();
        public abstract void BeginTransaction();

    }
}
