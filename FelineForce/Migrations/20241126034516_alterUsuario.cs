using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FelineForce.Migrations
{
    /// <inheritdoc />
    public partial class alterUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HorasTrabalhadas",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Salario",
                table: "Usuarios",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HorasTrabalhadas",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Salario",
                table: "Usuarios");
        }
    }
}
