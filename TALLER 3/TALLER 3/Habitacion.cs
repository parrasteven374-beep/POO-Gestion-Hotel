namespace TALLER_3
{
    public class Habitacion
    {
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public double PrecioNoche { get; set; }
        public bool Disponible { get; set; }

        public Habitacion(string numero, string tipo, double precioNoche)
        {
            Numero = numero;
            Tipo = tipo;
            PrecioNoche = precioNoche;
            Disponible = true;
        }
    }
}