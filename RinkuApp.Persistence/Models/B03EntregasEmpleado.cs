using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace RinkuApp.Persistence.Models
{
    public class B03EntregasEmpleado
    {
        [Key, Column("Id"), Display(Name = "Id")]
        public long Id { get; set; }

        [Column("IdEmpleado"), Required, Display(Name = "IdEmpleado"), StringLength(50)]
        public string? IdEmpleado { get; set; }

        [Column("CantidadEntregas"), Display(Name = "CantidadEntregas")]
        public int CantidadEntregas { get; set; }

        [Column("FechaEntrega")]
        public DateTime FechaEntrega { get; set; }

        [Column("created_by")]
        public string? CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedOn { get; set; }

        [Column("last_modified_by")]
        public string? LastModifiedBy { get; set; }

        [Column("last_modified_on")]
        public DateTime? LastModifiedOn { get; set; }
        //public B03EntregasEmpleado(B03EntregasEmpleado src)
        //{
        //    Id = src.Id;
        //    IdEmpleado = src.IdEmpleado;
        //    CantidadEntregas = src.CantidadEntregas;
        //    FechaEntrega = src.FechaEntrega;
        //    CreatedBy = src.CreatedBy;
        //    CreatedOn = src.CreatedOn;
        //    LastModifiedBy = src.LastModifiedBy;
        //    LastModifiedOn = src.LastModifiedOn;
        //}

        public void UpdateFromJson(JsonElement jsonrecord)
        {
            IdEmpleado = jsonrecord.TryGetProperty(nameof(IdEmpleado), out var elemIdEmpleado) ? elemIdEmpleado.GetString() : null;
            CantidadEntregas = jsonrecord.TryGetProperty(nameof(CantidadEntregas), out var elemCantidadEntregas) && elemCantidadEntregas.ValueKind != JsonValueKind.Null && elemCantidadEntregas.ValueKind != JsonValueKind.Undefined && elemCantidadEntregas.TryGetInt32(out var iselemCantidadEntregas) ? iselemCantidadEntregas : default;
            FechaEntrega = jsonrecord.TryGetProperty(nameof(FechaEntrega), out var elemFechaEntrega) ? elemFechaEntrega.GetDateTime() : default;
            CreatedBy = jsonrecord.TryGetProperty(nameof(CreatedBy), out var elemCreatedBy) ? elemCreatedBy.GetString() : null;
            CreatedOn = jsonrecord.TryGetProperty(nameof(CreatedOn), out var elemCreatedOn) ? elemCreatedOn.GetDateTime() : default;
            LastModifiedBy = jsonrecord.TryGetProperty(nameof(LastModifiedBy), out var elemLastModifiedBy) ? elemLastModifiedBy.GetString() : null;
            LastModifiedOn = jsonrecord.TryGetProperty(nameof(LastModifiedOn), out var elemLastModifiedOn) ? elemLastModifiedOn.GetDateTime() : default;


        }
    }
}
