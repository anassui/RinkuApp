using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RinkuApp.Persistence.Models
{
    public class BitacoraHorasLaboradas
    {
        [Key, Column("Id"), Display(Name = "Id")]
        public long Id { get; set; }

        [Column("IdEmpleado"), Required, Display(Name = "IdEmpleado"), StringLength(50)]
        public string? IdEmpleado { get; set; }

        [Column("Evento"), Required, Display(Name = "Evento"), StringLength(50)]
        public string? Evento { get; set; }

        [Column("Uuid"), Required, Display(Name = "Uuid"), StringLength(120)]
        public string? Uuid { get; set; }

        [Column("Mensaje"), Required, Display(Name = "Mensaje"), StringLength(500)]
        public string? Mensaje { get; set; }

        [Column("created_by")]
        public string? CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedOn { get; set; }

        [Column("last_modified_by")]
        public string? LastModifiedBy { get; set; }

        [Column("last_modified_on")]
        public DateTime? LastModifiedOn { get; set; }


        public BitacoraHorasLaboradas(BitacoraHorasLaboradas src)
        {
            Id = src.Id;
            IdEmpleado = src.IdEmpleado;
            Evento = src.Evento;
            Uuid = src.Uuid;
            Mensaje = src.Mensaje;
        }



        public void UpdateFromJson(JsonElement jsonrecord)
        {
            IdEmpleado = jsonrecord.TryGetProperty(nameof(IdEmpleado), out var elemIdEmpleado) ? elemIdEmpleado.GetString() : null;
            Evento = jsonrecord.TryGetProperty(nameof(Evento), out var elemEvento) ? elemEvento.GetString() : null;
            Uuid = jsonrecord.TryGetProperty(nameof(Uuid), out var elemUuid) ? elemUuid.GetString() : Uuid;
            Mensaje = jsonrecord.TryGetProperty(nameof(Mensaje), out var elemMensaje) ? elemMensaje.GetString() : null;
            CreatedBy = jsonrecord.TryGetProperty(nameof(CreatedBy), out var elemCreatedBy) ? elemCreatedBy.GetString() : null;
            CreatedOn = jsonrecord.TryGetProperty(nameof(CreatedOn), out var elemCreatedOn) ? elemCreatedOn.GetDateTime() : default;
            LastModifiedBy = jsonrecord.TryGetProperty(nameof(LastModifiedBy), out var elemLastModifiedBy) ? elemLastModifiedBy.GetString() : null;
            LastModifiedOn = jsonrecord.TryGetProperty(nameof(LastModifiedOn), out var elemLastModifiedOn) ? elemLastModifiedOn.GetDateTime() : default;
        }


    }
}
