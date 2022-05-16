using System.Data.SqlClient;

namespace Bootcamp_MVC_2.Models
{
    public class ListaVehiculos
    {
        public List<vehiculos> lista()
        {
        List<vehiculos> lista = new List<vehiculos>();

        SqlConnection conexion = Conexion.getConeccion();
        conexion.Open();

        string consulta = "Select * from VEHICULO";
        SqlCommand cmd = new SqlCommand(consulta, conexion);

        var resultados = cmd.ExecuteReader();
        while(resultados.Read())
        {
                lista.Add(new vehiculos(
                    (int)resultados["Id"],
                    (string)resultados["Marca"],
                    (string)resultados["Modelo"],
                    (int)resultados["Año"],
                    (double)resultados["Kilometros"],
                    (double)resultados["Precio"]
                    )
                    );
        }
            return lista;
        }
}
}
