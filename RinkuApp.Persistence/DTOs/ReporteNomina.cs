using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RinkuApp.Persistence.DTOs
{
    public class ReporteNomina
    {
        public long Id { get; set; }
        public string? IdEmpleado { get; set; }
        public string? IdRol { get; set; }
        public string? Salario { get; set; }
        public int CantidadEntregas { get; set; }
        public int TotalHorasLaboradas { get; set; }
        public int ISR { get; set; }
        public int BonosPorEntrega { get; set; }
        public int BonosDespensa { get; set; }
    }
}
