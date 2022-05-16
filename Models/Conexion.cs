using System.Data.SqlClient;

namespace Bootcamp_MVC_2.Models
{
    public static class Conexion
    {

        public static SqlConnection getConeccion()
        { 
        var constructor = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
        string cadenaSQL = constructor.GetSection("ConnectionStrings:conexion").Value;
        SqlConnection conexion = new SqlConnection(cadenaSQL);
        return conexion;
        }
    }
}
