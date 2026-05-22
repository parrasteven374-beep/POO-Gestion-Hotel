using System;
using System.Collections.Generic;

namespace TALLER_3
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Estado { get; set; }

        public Cliente ClienteReserva { get; set; }
        public Empleado EmpleadoEncargado { get; set; }
        public Habitacion HabitacionAsignada { get; set; }
        public Cobro CobroGenerado { get; set; }

        public List<Consumo> ListaConsumos { get; set; }

        public Reserva(int idReserva, DateTime ingreso, DateTime salida, Cliente cliente, Empleado empleado, Habitacion habitacion)
        {
            IdReserva = idReserva;
            FechaIngreso = ingreso;
            FechaSalida = salida;
            Estado = "Activa";
            ClienteReserva = cliente;
            EmpleadoEncargado = empleado;
            HabitacionAsignada = habitacion;
            ListaConsumos = new List<Consumo>();

            habitacion.Disponible = false;
        }

        public void AgregarServicio(Consumo nuevoConsumo)
        {
            ListaConsumos.Add(nuevoConsumo);
        }

        public void CalcularTotal()
        {
            int dias = (FechaSalida - FechaIngreso).Days;
            if (dias == 0) dias = 1;

            double totalHabitacion = dias * HabitacionAsignada.PrecioNoche;
            double totalConsumos = 0;

            foreach (var consumo in ListaConsumos)
            {
                totalConsumos += consumo.CalcularSubtotal();
            }

            double granTotal = totalHabitacion + totalConsumos;
            CobroGenerado = new Cobro(new Random().Next(1000, 9999), granTotal);
        }

        public void MostrarReserva()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"   DETALLE DE RESERVA #{IdReserva} - Estado: {Estado}");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine($"Cliente\t\t\t: {ClienteReserva.Nombre} | Doc: {ClienteReserva.Documento} | Tel: {ClienteReserva.Telefono}");
            Console.WriteLine($"Atendido por\t\t: {EmpleadoEncargado.Nombre} ({EmpleadoEncargado.Cargo})");
            Console.WriteLine($"Habitación\t\t: {HabitacionAsignada.Numero} ({HabitacionAsignada.Tipo})");
            Console.WriteLine($"Fechas\t\t\t: {FechaIngreso.ToShortDateString()} al {FechaSalida.ToShortDateString()}");

            Console.WriteLine("\nCONSUMOS ADICIONALES");
            if (ListaConsumos.Count == 0)
            {
                Console.WriteLine("No se registraron consumos adicionales.");
            }
            else
            {
                foreach (var c in ListaConsumos)
                {
                    Console.WriteLine($"- {c.Cantidad}x {c.Servicio.Nombre}\t: ${c.CalcularSubtotal()}");
                }
            }

            if (CobroGenerado != null)
            {
                Console.WriteLine("\nRESUMEN DE COBRO");
                Console.WriteLine($"Total a Pagar\t\t: ${CobroGenerado.Total}");
                Console.WriteLine($"Estado de Pago\t\t: {CobroGenerado.EstadoPago}");
            }
            Console.WriteLine("--------------------------------------------------\n");
        }
    }
}