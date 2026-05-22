using System;

namespace TALLER_3
{
    public class Cobro
    {
        public int IdCobro { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
        public string EstadoPago { get; set; }

        public Cobro(int idCobro, double total)
        {
            IdCobro = idCobro;
            Total = total;
            Fecha = DateTime.Now;
            EstadoPago = "Pendiente";
        }

        public void ProcesarPago()
        {
            EstadoPago = "Pagado";
            Console.WriteLine($"\n--- PAGO PROCESADO ---");
            Console.WriteLine($"Cobro #{IdCobro} por ${Total} ha sido pagado exitosamente.");
        }
    }
}