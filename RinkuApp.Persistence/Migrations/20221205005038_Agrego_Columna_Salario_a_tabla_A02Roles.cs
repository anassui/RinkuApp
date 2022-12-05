using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RinkuApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AgregoColumnaSalarioatablaA02Roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Salario",
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
                name: "Salario",
                table: "A02Roles");
        }
    }
}
