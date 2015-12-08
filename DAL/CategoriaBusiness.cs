using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CategoriaBusiness
    {
        public void InsertCategoria(Categoria oCategoria)
        {
            SqlConnection oConn = new SqlConnection(Constants.connectionString);
            oConn.Open();
            SqlTransaction oTran = oConn.BeginTransaction();
            try
            {
                using (CategoriaDataAccess tDataAccess = new CategoriaDataAccess())
                {
                    tDataAccess.Insert(oConn, oTran, oCategoria);
                }
                oTran.Commit();
            }
            catch (Exception ex)
            {
                oTran.Rollback();
                throw ex;
            }
            finally
            {
                oConn.Close();
                oTran.Dispose();
            }
        }

        public DataSet GetCategoriaById(Categoria oCategoria)
        {
            SqlConnection oConn = new SqlConnection(Constants.connectionString);
            oConn.Open();
            try
            {
                using (CategoriaDataAccess tDataAccess = new CategoriaDataAccess())
                {
                    return tDataAccess.GetById(oConn, null, oCategoria);
                }
            }
            finally
            {
                oConn.Close();
            }
        }

        public DataSet GetCategorias()
        {
            SqlConnection oConn = new SqlConnection(Constants.connectionString);
            oConn.Open();
            try
            {
                using (CategoriaDataAccess tDataAccess = new CategoriaDataAccess())
                {
                    return tDataAccess.GetAll(oConn, null);
                }
            }
            finally
            {
                oConn.Close();
            }
        }
    }
}