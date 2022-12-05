namespace RinkuApp.Persistence.DTOs
{
    public class EmpleadoModel
    {
        public long Id { get; set; }
        public string? IdEmpleado { get; set; }
        public string? IdRol { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Edad { get; set; }
        public string? Sexo { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public int Estatus { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public DateTime FechaComienzoRol { get; set; }
    }
}
