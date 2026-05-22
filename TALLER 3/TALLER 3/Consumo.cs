using System;

namespace TALLER_3
{
    public class Consumo
    {
        public int IdConsumo { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }

        public ServicioComplementario Servicio { get; set; }

        public Consumo(int idConsumo, int cantidad, ServicioComplementario servicio)
        {
            IdConsumo = idConsumo;
            Cantidad = cantidad;
            Servicio = servicio;
            Fecha = DateTime.Now;
        }

        public double CalcularSubtotal()
        {
            return Cantidad * Servicio.Costo;
        }
    }
}