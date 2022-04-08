namespace EjercicioEmpleados
{
    public abstract class Empleado
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public override string ToString() => $"Rut: {Rut}, Nombre: {Nombre} {Apellido}";
        public abstract string marcarIngreso();
        public virtual string firmarContrato() => "Firma contrato DIGITAL";
        public string MarcarSalida() => $"Empleado Rut: {Rut}, Marca Salida: {DateTime.Now}";
        
    }
}
