namespace TALLER_3
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }

        public Empleado(int idEmpleado, string nombre, string cargo)
        {
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Cargo = cargo;
        }
    }
}