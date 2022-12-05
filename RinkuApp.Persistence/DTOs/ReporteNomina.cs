namespace RinkuApp.Persistence.DTOs
{
    public class ReporteNomina
    {
        public long Id { get; set; }
        public string? IdEmpleado { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? IdRol { get; set; }
        public string? SalarioBase { get; set; }
        public string? BonoXHora { get; set; }
        public string? SalarioBaseXMes { get; set; }
        public string? EntregasXMes{ get; set; }
        public string? Mes{ get; set; }
        public string? AcumuladoBonosXEntrega{ get; set; }
        public string? AcumuladoBonoXRol{ get; set; }
        public string? SalarioBruto{ get; set; }
        public string? ISR{ get; set; }
        public string? ImpuestosAdicionales{ get; set; }
        public string? ValesDespensa{ get; set; } //calculados sobre el salario bruto
        public int TotalHorasLaboradas { get; set; } = 192;
    }
}
