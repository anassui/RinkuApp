using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RinkuApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AgregoColumnaSalarioBaseyBonosatablaA02Roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Salario",
                table: "A02Roles",
                newName: "SalarioBase");

            migrationBuilder.AddColumn<string>(
                name: "BonoXHora",
                table: "A02Roles",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BonoXHora",
                table: "A02Roles");

            migrationBuilder.RenameColumn(
                name: "SalarioBase",
                table: "A02Roles",
                newName: "Salario");
        }
    }
}
