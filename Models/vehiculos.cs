namespace Bootcamp_MVC_2.Models
{
    public class vehiculos
    {
        public int Id;
        public string marca;
        public string modelo;
        public int año;
        public double kilometro;
        public double precio;

        public vehiculos(int Id, string marca, string modelo, int año, double kilometro, double precio)
        { 
            this.Id = Id;
            this.marca= marca;
            this.modelo= modelo;
            this.año = año;
            this.kilometro = kilometro;
            this.precio = precio;
        } 

    }
}
