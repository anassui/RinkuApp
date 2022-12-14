// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RinkuApp.Persistence.Data;

#nullable disable

namespace RinkuApp.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221130173941_update_estructura-tablas_faltantes")]
    partial class updateestructuratablasfaltantes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RinkuApp.Persistence.Models.A01Empleados", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Apellidos");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Direccion");

                    b.Property<string>("Edad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Edad");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Email");

                    b.Property<int>("Estatus")
                        .HasColumnType("int")
                        .HasColumnName("Estatus");

                    b.Property<string>("IdEmpleado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("IdEmpleado");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_modified_on");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Nombre");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Sexo");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Telefono");

                    b.HasKey("Id");

                    b.ToTable("A01_Empleados");
                });

            modelBuilder.Entity("RinkuApp.Persistence.Models.A02Roles", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on");

                    b.Property<string>("DescripcionRol")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("DescripcionRol");

                    b.Property<int>("Estatus")
                        .HasColumnType("int")
                        .HasColumnName("Estatus");

                    b.Property<string>("IdRol")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("IdRol");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_modified_on");

                    b.HasKey("Id");

                    b.ToTable("A02Roles");
                });

            modelBuilder.Entity("RinkuApp.Persistence.Models.B01Salarios", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on");

                    b.Property<DateTime>("FechaContratacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaContratacion");

                    b.Property<string>("IdEmpleado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("IdEmpleado");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_modified_on");

                    b.Property<string>("Salario")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Salario");

                    b.HasKey("Id");

                    b.ToTable("B01Salarios");
                });

            modelBuilder.Entity("RinkuApp.Persistence.Models.B02RolEmpleado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on");

                    b.Property<DateTime>("FechaComienzoRol")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaComienzoRol");

                    b.Property<string>("IdEmpleado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("IdEmpleado");

                    b.Property<string>("IdRol")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("IdRol");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_modified_on");

                    b.HasKey("Id");

                    b.ToTable("B02RolEmpleado");
                });

            modelBuilder.Entity("RinkuApp.Persistence.Models.B03EntregasEmpleado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("CantidadEntregas")
                        .HasColumnType("int")
                        .HasColumnName("CantidadEntregas");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaEntrega");

                    b.Property<string>("IdEmpleado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("IdEmpleado");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_modified_on");

                    b.HasKey("Id");

                    b.ToTable("B03EntregasEmpleado");
                });

            modelBuilder.Entity("RinkuApp.Persistence.Models.BitacoraHorasLaboradas", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on");

                    b.Property<string>("Evento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Evento");

                    b.Property<string>("IdEmpleado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("IdEmpleado");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_modified_on");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Mensaje");

                    b.Property<string>("Uuid")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasColumnName("Uuid");

                    b.HasKey("Id");

                    b.ToTable("BitacoraHorasLaboradas");
                });

            modelBuilder.Entity("RinkuApp.Persistence.Models.X01ParametrosGenerales", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_on");

                    b.Property<string>("EsParametroInterno")
                        .HasMaxLength(1)
                        .HasColumnType("varchar")
                        .HasColumnName("es_parametro_interno");

                    b.Property<string>("GrupoParametro")
                        .HasMaxLength(250)
                        .HasColumnType("varchar")
                        .HasColumnName("grupo_parametro");

                    b.Property<string>("IdParametro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("id_parametro");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_modified_on");

                    b.Property<string>("LimiteInferior")
                        .HasMaxLength(250)
                        .HasColumnType("varchar")
                        .HasColumnName("limite_inferior");

                    b.Property<string>("LimiteSuperior")
                        .HasMaxLength(250)
                        .HasColumnType("varchar")
                        .HasColumnName("limite_superior");

                    b.Property<string>("NombreParametro")
                        .HasMaxLength(250)
                        .HasColumnType("varchar")
                        .HasColumnName("nombre_parametro");

                    b.Property<string>("PuedeSerVacioCero")
                        .HasMaxLength(1)
                        .HasColumnType("varchar")
                        .HasColumnName("puede_ser_vacio_cero");

                    b.Property<string>("TipoParametro")
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("tipo_parametro");

                    b.Property<string>("TipoValor")
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("tipo_valor");

                    b.Property<string>("UnidadMedida")
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("unidad_medida");

                    b.Property<string>("ValorParametro")
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("valor_parametro");

                    b.HasKey("Id");

                    b.ToTable("X01ParametrosGenerales");
                });
#pragma warning restore 612, 618
        }
    }
}
