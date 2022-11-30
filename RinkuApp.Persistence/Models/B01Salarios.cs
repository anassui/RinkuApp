using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;
using System.Text.Json;

namespace RinkuApp.Persistence.Models
{
    public class B01Salarios
    {
        [Key, Column("Id"), Display(Name = "Id")]
        public long Id { get; set; }

        [Column("IdEmpleado"), Required, Display(Name = "IdEmpleado"), StringLength(50)]
        public string? IdEmpleado { get; set; }

        [Column("Salario"), Required, Display(Name = "Salario"), StringLength(300)]
        public string? Salario { get; set; }

        [Column("FechaContratacion")]
        public DateTime FechaContratacion { get; set; }
       
        [Column("created_by")]
        public string? CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedOn { get; set; }

        [Column("last_modified_by")]
        public string? LastModifiedBy { get; set; }

        [Column("last_modified_on")]
        public DateTime? LastModifiedOn { get; set; }

        public B01Salarios(B01Salarios src)
        {
            Id = src.Id;
            IdEmpleado = src.IdEmpleado;
            Salario = src.Salario;
            FechaContratacion = src.FechaContratacion;
            CreatedBy = src.CreatedBy;
            CreatedOn = src.CreatedOn;
            LastModifiedBy = src.LastModifiedBy;
            LastModifiedOn = src.LastModifiedOn;
        }

        public void UpdateFromJson(JsonElement jsonrecord)
        {
            IdEmpleado = jsonrecord.TryGetProperty(nameof(IdEmpleado), out var elemIdEmpleado) ? elemIdEmpleado.GetString() : null;
            Salario = jsonrecord.TryGetProperty(nameof(Salario), out var elemSalario) ? elemSalario.GetString() : null;
            FechaContratacion = jsonrecord.TryGetProperty(nameof(FechaContratacion), out var elemFechaContratacion) ? elemFechaContratacion.GetDateTime() : default;
            CreatedBy = jsonrecord.TryGetProperty(nameof(CreatedBy), out var elemCreatedBy) ? elemCreatedBy.GetString() : null;
            CreatedOn = jsonrecord.TryGetProperty(nameof(CreatedOn), out var elemCreatedOn) ? elemCreatedOn.GetDateTime() : default;
            LastModifiedBy = jsonrecord.TryGetProperty(nameof(LastModifiedBy), out var elemLastModifiedBy) ? elemLastModifiedBy.GetString() : null;
            LastModifiedOn = jsonrecord.TryGetProperty(nameof(LastModifiedOn), out var elemLastModifiedOn) ? elemLastModifiedOn.GetDateTime() : default;


        }
    }
}
