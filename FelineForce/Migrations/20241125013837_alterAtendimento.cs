using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FelineForce.Migrations
{
    /// <inheritdoc />
    public partial class alterAtendimento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Clientes_ClienteId",
                table: "Atendimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Gatos_GatoId",
                table: "Atendimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Usuarios_UsuarioId",
                table: "Atendimentos");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_ClienteId",
                table: "Atendimentos");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_UsuarioId",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Atendimentos");

            migrationBuilder.AlterColumn<Guid>(
                name: "GatoId",
                table: "Atendimentos",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "AtendenteId",
                table: "Atendimentos",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "TutorId",
                table: "Atendimentos",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_AtendenteId",
                table: "Atendimentos",
                column: "AtendenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_TutorId",
                table: "Atendimentos",
                column: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Clientes_TutorId",
                table: "Atendimentos",
                column: "TutorId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Gatos_GatoId",
                table: "Atendimentos",
                column: "GatoId",
                principalTable: "Gatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Usuarios_AtendenteId",
                table: "Atendimentos",
                column: "AtendenteId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Clientes_TutorId",
                table: "Atendimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Gatos_GatoId",
                table: "Atendimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Usuarios_AtendenteId",
                table: "Atendimentos");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_AtendenteId",
                table: "Atendimentos");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_TutorId",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "AtendenteId",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "TutorId",
                table: "Atendimentos");

            migrationBuilder.AlterColumn<Guid>(
                name: "GatoId",
                table: "Atendimentos",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "Atendimentos",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Atendimentos",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_ClienteId",
                table: "Atendimentos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_UsuarioId",
                table: "Atendimentos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Clientes_ClienteId",
                table: "Atendimentos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Gatos_GatoId",
                table: "Atendimentos",
                column: "GatoId",
                principalTable: "Gatos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Usuarios_UsuarioId",
                table: "Atendimentos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
