using System.Data.SqlClient;

namespace Bootcamp_MVC_2.Models
{
    public class Config
    {
        private string nombre;
        private string descripcion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Config()
        {
            SqlConnection conexion = Conexion.getConeccion();
            conexion.Open();

            string consulta = "Select * from CONFIG";
            SqlCommand cmd = new SqlCommand(consulta, conexion);

            var resultados = cmd.ExecuteReader();
            while(resultados.Read())
            {
                this.nombre = (string)resultados["nombre"];
                this.descripcion = (string)resultados["descripcion"];
            }
            
        }
    }
}
