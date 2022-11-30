using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RinkuApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddA01Empleados01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "A01_Empleados",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "IdEmpleado",
                table: "A01_Empleados",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "A01_Empleados",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "A01_Empleados",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Edad",
                table: "A01_Empleados",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "A01_Empleados",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Estatus",
                table: "A01_Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "A01_Empleados",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "A01_Empleados",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "A01_Empleados",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "created_by",
                table: "A01_Empleados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_on",
                table: "A01_Empleados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "last_modified_by",
                table: "A01_Empleados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "last_modified_on",
                table: "A01_Empleados",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "A01_Empleados");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "A01_Empleados");

            migrationBuilder.DropColumn(
                name: "Edad",
                table: "A01_Empleados");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "A01_Empleados");

            migrationBuilder.DropColumn(
                name: "Estatus",
                table: "A01_Empleados");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "A01_Empleados");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "A01_Empleados");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "A01_Empleados");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "A01_Empleados");

            migrationBuilder.DropColumn(
                name: "created_on",
                table: "A01_Empleados");

            migrationBuilder.DropColumn(
                name: "last_modified_by",
                table: "A01_Empleados");

            migrationBuilder.DropColumn(
                name: "last_modified_on",
                table: "A01_Empleados");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "A01_Empleados",
                newName: "id");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdEmpleado",
                table: "A01_Empleados",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
