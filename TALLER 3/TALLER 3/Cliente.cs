using System;

namespace TALLER_3
{
    public class Cliente
    {
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Cliente(string idCliente, string nombre, string documento, string telefono, string correo)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Documento = documento;
            Telefono = telefono;
            Correo = correo;
        }

        public void MostrarCliente()
        {
            Console.WriteLine($"Cliente: {Nombre} | Doc: {Documento} | Tel: {Telefono}");
        }
    }
}