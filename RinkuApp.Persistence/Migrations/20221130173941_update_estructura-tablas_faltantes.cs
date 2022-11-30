using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RinkuApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateestructuratablasfaltantes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "A02Roles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DescripcionRol = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Estatus = table.Column<int>(type: "int", nullable: false),
                    createdby = table.Column<string>(name: "created_by", type: "nvarchar(max)", nullable: true),
                    createdon = table.Column<DateTime>(name: "created_on", type: "datetime2", nullable: false),
                    lastmodifiedby = table.Column<string>(name: "last_modified_by", type: "nvarchar(max)", nullable: true),
                    lastmodifiedon = table.Column<DateTime>(name: "last_modified_on", type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A02Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "B01Salarios",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpleado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salario = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    FechaContratacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdby = table.Column<string>(name: "created_by", type: "nvarchar(max)", nullable: true),
                    createdon = table.Column<DateTime>(name: "created_on", type: "datetime2", nullable: false),
                    lastmodifiedby = table.Column<string>(name: "last_modified_by", type: "nvarchar(max)", nullable: true),
                    lastmodifiedon = table.Column<DateTime>(name: "last_modified_on", type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B01Salarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "B02RolEmpleado",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpleado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdRol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaComienzoRol = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdby = table.Column<string>(name: "created_by", type: "nvarchar(max)", nullable: true),
                    createdon = table.Column<DateTime>(name: "created_on", type: "datetime2", nullable: false),
                    lastmodifiedby = table.Column<string>(name: "last_modified_by", type: "nvarchar(max)", nullable: true),
                    lastmodifiedon = table.Column<DateTime>(name: "last_modified_on", type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B02RolEmpleado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "B03EntregasEmpleado",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpleado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CantidadEntregas = table.Column<int>(type: "int", nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdby = table.Column<string>(name: "created_by", type: "nvarchar(max)", nullable: true),
                    createdon = table.Column<DateTime>(name: "created_on", type: "datetime2", nullable: false),
                    lastmodifiedby = table.Column<string>(name: "last_modified_by", type: "nvarchar(max)", nullable: true),
                    lastmodifiedon = table.Column<DateTime>(name: "last_modified_on", type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B03EntregasEmpleado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BitacoraHorasLaboradas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpleado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Evento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Uuid = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Mensaje = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    createdby = table.Column<string>(name: "created_by", type: "nvarchar(max)", nullable: true),
                    createdon = table.Column<DateTime>(name: "created_on", type: "datetime2", nullable: false),
                    lastmodifiedby = table.Column<string>(name: "last_modified_by", type: "nvarchar(max)", nullable: true),
                    lastmodifiedon = table.Column<DateTime>(name: "last_modified_on", type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitacoraHorasLaboradas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "X01ParametrosGenerales",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idparametro = table.Column<string>(name: "id_parametro", type: "varchar(50)", maxLength: 50, nullable: false),
                    nombreparametro = table.Column<string>(name: "nombre_parametro", type: "varchar(250)", maxLength: 250, nullable: true),
                    tipoparametro = table.Column<string>(name: "tipo_parametro", type: "varchar(50)", maxLength: 50, nullable: true),
                    grupoparametro = table.Column<string>(name: "grupo_parametro", type: "varchar(250)", maxLength: 250, nullable: true),
                    valorparametro = table.Column<string>(name: "valor_parametro", type: "varchar(50)", maxLength: 50, nullable: true),
                    unidadmedida = table.Column<string>(name: "unidad_medida", type: "varchar(50)", maxLength: 50, nullable: true),
                    tipovalor = table.Column<string>(name: "tipo_valor", type: "varchar(50)", maxLength: 50, nullable: true),
                    limiteinferior = table.Column<string>(name: "limite_inferior", type: "varchar(250)", maxLength: 250, nullable: true),
                    limitesuperior = table.Column<string>(name: "limite_superior", type: "varchar(250)", maxLength: 250, nullable: true),
                    esparametrointerno = table.Column<string>(name: "es_parametro_interno", type: "varchar(1)", maxLength: 1, nullable: true),
                    puedeservaciocero = table.Column<string>(name: "puede_ser_vacio_cero", type: "varchar(1)", maxLength: 1, nullable: true),
                    createdby = table.Column<string>(name: "created_by", type: "nvarchar(max)", nullable: true),
                    createdon = table.Column<DateTime>(name: "created_on", type: "datetime2", nullable: false),
                    lastmodifiedby = table.Column<string>(name: "last_modified_by", type: "nvarchar(max)", nullable: true),
                    lastmodifiedon = table.Column<DateTime>(name: "last_modified_on", type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X01ParametrosGenerales", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A02Roles");

            migrationBuilder.DropTable(
                name: "B01Salarios");

            migrationBuilder.DropTable(
                name: "B02RolEmpleado");

            migrationBuilder.DropTable(
                name: "B03EntregasEmpleado");

            migrationBuilder.DropTable(
                name: "BitacoraHorasLaboradas");

            migrationBuilder.DropTable(
                name: "X01ParametrosGenerales");
        }
    }
}
