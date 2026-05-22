using System;

namespace TALLER_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1, "Carlos Pérez", "Recepcionista");
            Habitacion hab101 = new Habitacion("101", "Sencilla", 150000);

            ServicioComplementario servRestaurante = new ServicioComplementario("Desayuno", 25000);
            ServicioComplementario servSpa = new ServicioComplementario("Masaje Spa", 80000);

            Cliente cliente1 = new Cliente("C01", "Ana Gómez", "1098765432", "3150000000", "ana@correo.com");

            DateTime fechaIngreso = DateTime.Now;
            DateTime fechaSalida = DateTime.Now.AddDays(3);

            Reserva miReserva = new Reserva(1, fechaIngreso, fechaSalida, cliente1, empleado1, hab101);

            Consumo consumo1 = new Consumo(1, 2, servRestaurante);
            Consumo consumo2 = new Consumo(2, 1, servSpa);

            miReserva.AgregarServicio(consumo1);
            miReserva.AgregarServicio(consumo2);

            miReserva.CalcularTotal();

            miReserva.MostrarReserva();

            miReserva.CobroGenerado.ProcesarPago();
            miReserva.MostrarReserva();

            Console.ReadLine();
        }
    }
}