using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace RinkuApp.Persistence.Models
{
    public class X01ParametrosGenerales
    {
        [Key, Column("Id"), Display(Name = "Id")]
        public long Id { get; set; }

        [Column("id_parametro", TypeName = "varchar"), Required, Display(Name = "Id Parametro"), StringLength(50)]
        public string? IdParametro { get; set; }

        [Column("nombre_parametro", TypeName = "varchar"), Display(Name = "Nombre Parametro"), StringLength(250)]
        public string? NombreParametro { get; set; }

        [Column("tipo_parametro", TypeName = "varchar"), Display(Name = "Tipo Parametro"), StringLength(50)]
        public string? TipoParametro { get; set; }

        [Column("grupo_parametro", TypeName = "varchar"), Display(Name = "Grupo Parametro"), StringLength(250)]
        public string? GrupoParametro { get; set; }

        [Column("valor_parametro", TypeName = "varchar"), Display(Name = "Valor Parametro"), StringLength(50)]
        public string? ValorParametro { get; set; }

        [Column("unidad_medida", TypeName = "varchar"), Display(Name = "Unidad Medida"), StringLength(50)]
        public string? UnidadMedida { get; set; }

        [Column("tipo_valor", TypeName = "varchar"), Display(Name = "Tipo Valor"), StringLength(50)]
        public string? TipoValor { get; set; }

        [Column("limite_inferior", TypeName = "varchar"), Display(Name = "Limite Inferior"), StringLength(250)]
        public string ?LimiteInferior { get; set; }

        [Column("limite_superior", TypeName = "varchar"), Display(Name = "Limite Superior"), StringLength(250)]
        public string? LimiteSuperior { get; set; }

        [Column("es_parametro_interno", TypeName = "varchar"), Display(Name = "Es Parametro Interno"), StringLength(1)]
        public string? EsParametroInterno { get; set; }

        [Column("puede_ser_vacio_cero", TypeName = "varchar"), Display(Name = "Puede Ser Vacio Cero"), StringLength(1)]
        public string? PuedeSerVacioCero { get; set; }

        [Column("created_by")]
        public string? CreatedBy { get; set; }

        [Column("created_on")]
        public DateTime CreatedOn { get; set; }

        [Column("last_modified_by")]
        public string? LastModifiedBy { get; set; }

        [Column("last_modified_on")]
        public DateTime? LastModifiedOn { get; set; }
        public X01ParametrosGenerales(X01ParametrosGenerales src) 
        {
            Id = src.Id;
            IdParametro = src.IdParametro;
            NombreParametro = src.NombreParametro;
            TipoParametro = src.TipoParametro;
            GrupoParametro = src.GrupoParametro;
            ValorParametro = src.ValorParametro;
            UnidadMedida = src.UnidadMedida;
            TipoValor = src.TipoValor;
            LimiteInferior = src.LimiteInferior;
            LimiteSuperior = src.LimiteSuperior;
            EsParametroInterno = src.EsParametroInterno;
            PuedeSerVacioCero = src.PuedeSerVacioCero;
            CreatedBy = src.CreatedBy;
            CreatedOn = src.CreatedOn;
            LastModifiedBy = src.LastModifiedBy;
            LastModifiedOn = src.LastModifiedOn;
        }

        

        public  void UpdateFromJson(JsonElement jsonRecord)
        {
            IdParametro = jsonRecord.TryGetProperty(nameof(IdParametro), out var elemIdParametro) ? elemIdParametro.GetString() : null;
            NombreParametro = jsonRecord.TryGetProperty(nameof(NombreParametro), out var elemNombreParametro) ? elemNombreParametro.GetString() : null;
            TipoParametro = jsonRecord.TryGetProperty(nameof(TipoParametro), out var elemTipoParametro) ? elemTipoParametro.GetString() : null;
            GrupoParametro = jsonRecord.TryGetProperty(nameof(GrupoParametro), out var elemGrupoParametro) ? elemGrupoParametro.GetString() : null;
            ValorParametro = jsonRecord.TryGetProperty(nameof(ValorParametro), out var elemValorParametro) ? elemValorParametro.GetString() : null;
            UnidadMedida = jsonRecord.TryGetProperty(nameof(UnidadMedida), out var elemUnidadMedida) ? elemUnidadMedida.GetString() : null;
            TipoValor = jsonRecord.TryGetProperty(nameof(TipoValor), out var elemTipoValor) ? elemTipoValor.GetString() : null;
            LimiteInferior = jsonRecord.TryGetProperty(nameof(LimiteInferior), out var elemLimiteInferior) ? elemLimiteInferior.GetString() : null;
            LimiteSuperior = jsonRecord.TryGetProperty(nameof(LimiteSuperior), out var elemLimiteSuperior) ? elemLimiteSuperior.GetString() : null;
            EsParametroInterno = jsonRecord.TryGetProperty(nameof(EsParametroInterno), out var elemEsParametroInterno) ? elemEsParametroInterno.GetString() : null;
            PuedeSerVacioCero = jsonRecord.TryGetProperty(nameof(PuedeSerVacioCero), out var elemPuedeSerVacioCero) ? elemPuedeSerVacioCero.GetString() : null;
            CreatedBy = jsonRecord.TryGetProperty(nameof(CreatedBy), out var elemCreatedBy) ? elemCreatedBy.GetString() : null;
            CreatedOn = jsonRecord.TryGetProperty(nameof(CreatedOn), out var elemCreatedOn) ? elemCreatedOn.GetDateTime() : default;
            LastModifiedBy = jsonRecord.TryGetProperty(nameof(LastModifiedBy), out var elemLastModifiedBy) ? elemLastModifiedBy.GetString() : null;
            LastModifiedOn = jsonRecord.TryGetProperty(nameof(LastModifiedOn), out var elemLastModifiedOn) ? elemLastModifiedOn.GetDateTime() : default;
        }

       
    }
}
