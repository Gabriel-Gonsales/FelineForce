using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FelineForce.Migrations
{
    /// <inheritdoc />
    public partial class mudaRelacaoGato : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Gatos");

            migrationBuilder.AddForeignKey(
                name: "FK_Gatos_Clientes_TutorId",
                table: "Gatos",
                column: "TutorId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gatos_Clientes_TutorId",
                table: "Gatos");

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "Gatos",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");
        }
    }
}
