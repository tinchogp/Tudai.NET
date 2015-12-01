using System.Web.Configuration;

namespace DAL
{
    static class Constants
    {
        public const string esquema = "dbo";
        public const string tablaNoticias = "Noticia";
        public readonly static string connectionString = WebConfigurationManager.ConnectionStrings["tudaiConnectionString"].ConnectionString;
    }
}