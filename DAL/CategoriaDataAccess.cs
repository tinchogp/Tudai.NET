using System;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CategoriaDataAccess : IDisposable
    {
        public void Insert(SqlConnection oConn, SqlTransaction oTran, Categoria oCategoria)
        {
            using (SqlCommand oComm = new SqlCommand())
            {
                oComm.Connection = (oTran != null) ? oTran.Connection : oConn;
                oComm.Transaction = oTran;

                oComm.CommandType = CommandType.Text;
                oComm.CommandText = string.Format("INSERT INTO {0}.{1}(nombre) VALUES (@nombre)", Constants.esquema, Constants.tablaCategorias);

                oComm.Parameters.AddWithValue("@nombre", oCategoria.Nombre);                

                oComm.ExecuteNonQuery();
            }
        }

        public DataSet GetById(SqlConnection oConn, SqlTransaction oTran, Categoria oCategoria)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                using (SqlCommand oComm = new SqlCommand())
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        oComm.Connection = oTran != null ? oTran.Connection : oConn;
                        oComm.Transaction = oTran;

                        oComm.CommandType = CommandType.Text;
                        oComm.CommandText = string.Format("SELECT [id],[nombre] FROM {0}.{1} WHERE id=@id", Constants.esquema, Constants.tablaCategorias);

                        oComm.Parameters.AddWithValue("id",oCategoria.Id);

                        adapter.SelectCommand = oComm;
                        adapter.Fill(ds);

                        return ds;
                    }
                    finally
                    {
                    }
                }
            }
        }

        public DataSet GetAll(SqlConnection oConn, SqlTransaction oTran)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                using (SqlCommand oComm = new SqlCommand())
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        oComm.Connection = oTran != null ? oTran.Connection : oConn;
                        oComm.Transaction = oTran;

                        oComm.CommandType = CommandType.Text;
                        oComm.CommandText = string.Format("SELECT [id],[nombre] FROM {0}.{1}", Constants.esquema, Constants.tablaCategorias);
                        
                        adapter.SelectCommand = oComm;
                        adapter.Fill(ds);

                        return ds;
                    }
                    finally
                    {
                    }
                }
            }
        }

        public void Dispose() { }
    }
}