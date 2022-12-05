namespace RinkuApp.Persistence.DTOs
{
    public class EmpleadosRoles
    {
        public long Id { get; set; }
        public string? IdEmpleado { get; set; }
        public string? Nombre { get; set; }
        public string? IdRol { get; set; }
        public int Estatus { get; set; }
        public DateTime FechaComienzoRol { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
