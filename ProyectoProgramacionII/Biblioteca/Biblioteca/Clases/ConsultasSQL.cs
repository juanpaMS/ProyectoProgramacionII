using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Biblioteca.Clases
{
    public class ConsultasSQL
    {
        private SqlConnection conexion = new SqlConnection("Data Source = localhost;Initial Catalog = root;Integrated Security = True");
        private DataSet ds; //guarda varias tablas llamadas "dataTable"

        public DataTable MostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from Usuario", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            ds = new DataSet();
            ad.Fill(ds, "Table");
            conexion.Close();
            return ds.Tables["Table"];
        }
        public DataTable Buscar(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from Usuario where nombre like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            ds = new DataSet();
            ad.Fill(ds, "Table");
            conexion.Close();
            return ds.Tables["Table"];
        }

        public bool Insertar(string nombre, string id){

            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into usuario values '{0}', {1}", new string[] { nombre, id }), conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0) return true;
            else return false;
        }

        public bool Eliminar(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from usuario where nombre = {0}", nombre), conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasAfectadas > 0) return true;
            else return false;
        }
        public bool Actualizar(string id, string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update usuario set nombre = {0}, id = {1}", new string[] { nombre, id }));
            conexion.Close();
            int filasAfectadas = cmd.ExecuteNonQuery();
            if (filasAfectadas > 0) return true;
            else return false;
        }
    }
}
