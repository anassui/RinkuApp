using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace RinkuApp.Persistence.Models
{
    [Table("A01_Empleados")]
    public class A01Empleados
    {
        [Key, Column("Id"), Display(Name = "Id")]
        public long Id { get; set; }

        [Column("IdEmpleado"), Required, Display(Name = "IdEmpleado"), StringLength(50)]
        public string? IdEmpleado { get; set; }


        [Column("Nombre"), Required, Display(Name = "Nombre"), StringLength(100)]
        public string? Nombre { get; set; }

        [Column("Apellidos"), Required, Display(Name = "Apellidos"), StringLength(100)]
        public string? Apellidos { get; set; }

        [Column("Edad"), Required, Display(Name = "Edad"), StringLength(20)]
        public string? Edad { get; set; }
        [Column("Sexo"), Required, Display(Name = "Sexo"), StringLength(30)]
        public string? Sexo { get; set; }
        [Column("Email"), Required, Display(Name = "Email"), StringLength(100)]
        public string? Email { get; set; }

        [Column("Telefono"), Required, Display(Name = "Telefono"), StringLength(20)]
        public string? Telefono { get; set; }

        [Column("Direccion"), Required, Display(Name = "Direccion"), StringLength(300)]
        public string? Direccion { get; set; }

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

        //public A01Empleados(A01Empleados src)
        //{
        //    Id = src.Id;
        //    IdEmpleado = src.IdEmpleado;
        //    Nombre = src.Nombre;
        //    Apellidos = src.Apellidos;
        //    Edad = src.Edad;
        //    Sexo = src.Sexo;
        //    Email = src.Email;
        //    Telefono = src.Telefono;
        //    Direccion = src.Direccion;
        //    Estatus = src.Estatus;
        //    CreatedBy = src.CreatedBy;
        //    CreatedOn = src.CreatedOn;
        //    LastModifiedBy = src.LastModifiedBy;
        //    LastModifiedOn = src.LastModifiedOn;
        //}

        public void UpdateFromJson(JsonElement jsonrecord)
        {

            IdEmpleado = jsonrecord.TryGetProperty(nameof(IdEmpleado), out var elemIdEmpleado) ? elemIdEmpleado.GetString() : null;
            Nombre = jsonrecord.TryGetProperty(nameof(Nombre), out var elemNombre) ? elemNombre.GetString() : null;
            Apellidos = jsonrecord.TryGetProperty(nameof(Apellidos), out var elemApellidos) ? elemApellidos.GetString() : null;
            Edad = jsonrecord.TryGetProperty(nameof(Edad), out var elemEdad) ? elemEdad.GetString() : null;
            Sexo = jsonrecord.TryGetProperty(nameof(Sexo), out var elemSexo) ? elemEdad.GetString() : null;
            Email = jsonrecord.TryGetProperty(nameof(Email), out var elemEmail) ? elemEmail.GetString() : null;
            Telefono = jsonrecord.TryGetProperty(nameof(Telefono), out var elemTelefono) ? elemTelefono.GetString() : null;
            Direccion = jsonrecord.TryGetProperty(nameof(Direccion), out var elemDireccion) ? elemDireccion.GetString() : null;
            Estatus = jsonrecord.TryGetProperty(nameof(Estatus), out var elemEstatus) && elemEstatus.ValueKind != JsonValueKind.Null && elemEstatus.ValueKind != JsonValueKind.Undefined && elemEstatus.TryGetInt32(out var isEstatus) ? isEstatus : default;
            CreatedBy = jsonrecord.TryGetProperty(nameof(CreatedBy), out var elemCreatedBy) ? elemCreatedBy.GetString() : null;
            CreatedOn = jsonrecord.TryGetProperty(nameof(CreatedOn), out var elemCreatedOn) ? elemCreatedOn.GetDateTime() : default;
            LastModifiedBy = jsonrecord.TryGetProperty(nameof(LastModifiedBy), out var elemLastModifiedBy) ? elemLastModifiedBy.GetString() : null;
            LastModifiedOn = jsonrecord.TryGetProperty(nameof(LastModifiedOn), out var elemLastModifiedOn) ? elemLastModifiedOn.GetDateTime() : default;


        }
    }
}
