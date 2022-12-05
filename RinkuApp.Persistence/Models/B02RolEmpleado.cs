using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using RinkuApp.Persistence.DTOs;

namespace RinkuApp.Persistence.Models
{
    public class B02RolEmpleado
    {

        [Key, Column("Id"), Display(Name = "Id")]
        public long Id { get; set; }

        [Column("IdEmpleado"), Required, Display(Name = "IdEmpleado"), StringLength(50)]
        public string? IdEmpleado { get; set; }

        [Column("IdRol"), Required, Display(Name = "IdRol"), StringLength(50)]
        public string? IdRol { get; set; }

        [Column("FechaComienzoRol")]
        public DateTime FechaComienzoRol { get; set; }

        [Column("created_by")]
        public string? CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedOn { get; set; }

        [Column("last_modified_by")]
        public string? LastModifiedBy { get; set; }

        [Column("last_modified_on")]
        public DateTime? LastModifiedOn { get; set; }

        public B02RolEmpleado()
        {
        }

        public B02RolEmpleado(EmpleadoModel src)
        {
            Id = src.Id;
            IdEmpleado = src.IdEmpleado;
            IdRol = src.IdRol;
            FechaComienzoRol = src.FechaComienzoRol;
            CreatedBy = src.CreatedBy;
            CreatedOn = src.CreatedOn;
            LastModifiedBy = src.LastModifiedBy;
            LastModifiedOn = src.LastModifiedOn;
        }




        public void UpdateFromJson(JsonElement jsonrecord)
        {
            IdEmpleado = jsonrecord.TryGetProperty(nameof(IdEmpleado), out var elemIdEmpleado) ? elemIdEmpleado.GetString() : null;
            IdRol = jsonrecord.TryGetProperty(nameof(IdRol), out var elemIdRol) ? elemIdRol.GetString() : null;
            FechaComienzoRol = jsonrecord.TryGetProperty(nameof(FechaComienzoRol), out var elemFechaComienzoRol) ? elemFechaComienzoRol.GetDateTime() : default;
            CreatedBy = jsonrecord.TryGetProperty(nameof(CreatedBy), out var elemCreatedBy) ? elemCreatedBy.GetString() : null;
            CreatedOn = jsonrecord.TryGetProperty(nameof(CreatedOn), out var elemCreatedOn) ? elemCreatedOn.GetDateTime() : default;
            LastModifiedBy = jsonrecord.TryGetProperty(nameof(LastModifiedBy), out var elemLastModifiedBy) ? elemLastModifiedBy.GetString() : null;
            LastModifiedOn = jsonrecord.TryGetProperty(nameof(LastModifiedOn), out var elemLastModifiedOn) ? elemLastModifiedOn.GetDateTime() : default;


        }
    }
}
