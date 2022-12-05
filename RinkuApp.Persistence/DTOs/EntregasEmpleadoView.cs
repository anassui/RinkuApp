using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RinkuApp.Persistence.DTOs
{
    public class EntregasEmpleadoView
    {
        public long Id { get; set; }
        public string? IdEmpleado { get; set; }
        public string? Nombre { get; set; }
        public string? Rol { get; set; }
        public int CantidadEntregas { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
