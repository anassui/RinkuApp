using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace RinkuApp.Persistence.Models
{
    public class A02Roles
    {
        [Key, Column("Id"), Display(Name = "Id")]
        public long Id { get; set; }

        [Column("IdRol"), Required, Display(Name = "IdRol"), StringLength(50)]
        public string? IdRol { get; set; }

        [Column("DescripcionRol"), Required, Display(Name = "DescripcionRol"), StringLength(300)]
        public string? DescripcionRol { get; set; }

        [Column("Estatus"), Display(Name = "Estatus")]
        public int Estatus { get; set; }

        [Column("created_by")]
        public string? CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedOn { get; set; }

        [Column("last_modified_by")]
        public string? LastModifiedBy { get; set; }

        [Column("last_modified_on")]
        public DateTime? LastModifiedOn { get; set; }

        //public A02Roles(A02Roles src)
        //{
        //    Id = src.Id;
        //    IdRol = src.IdRol;
        //    DescripcionRol = src.DescripcionRol;
        //    Estatus = src.Estatus;
        //    CreatedBy = src.CreatedBy;
        //    CreatedOn = src.CreatedOn;
        //    LastModifiedBy = src.LastModifiedBy;
        //    LastModifiedOn = src.LastModifiedOn;
        //}

        public void UpdateFromJson(JsonElement jsonrecord)
        {

            IdRol = jsonrecord.TryGetProperty(nameof(IdRol), out var elemIdRol) ? elemIdRol.GetString() : null;
            DescripcionRol = jsonrecord.TryGetProperty(nameof(DescripcionRol), out var elemDescripcionRol) ? elemDescripcionRol.GetString() : null;
            Estatus = jsonrecord.TryGetProperty(nameof(Estatus), out var elemEstatus) && elemEstatus.ValueKind != JsonValueKind.Null && elemEstatus.ValueKind != JsonValueKind.Undefined && elemEstatus.TryGetInt32(out var isEstatus) ? isEstatus : default;
            CreatedBy = jsonrecord.TryGetProperty(nameof(CreatedBy), out var elemCreatedBy) ? elemCreatedBy.GetString() : null;
            CreatedOn = jsonrecord.TryGetProperty(nameof(CreatedOn), out var elemCreatedOn) ? elemCreatedOn.GetDateTime() : default;
            LastModifiedBy = jsonrecord.TryGetProperty(nameof(LastModifiedBy), out var elemLastModifiedBy) ? elemLastModifiedBy.GetString() : null;
            LastModifiedOn = jsonrecord.TryGetProperty(nameof(LastModifiedOn), out var elemLastModifiedOn) ? elemLastModifiedOn.GetDateTime() : default;


        }
    }
}
