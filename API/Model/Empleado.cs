namespace API.Model
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }

    }
}
