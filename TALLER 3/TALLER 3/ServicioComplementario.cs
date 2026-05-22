namespace TALLER_3
{
    public class ServicioComplementario
    {
        public string Nombre { get; set; }
        public double Costo { get; set; }

        public ServicioComplementario(string nombre, double costo)
        {
            Nombre = nombre;
            Costo = costo;
        }
    }
}