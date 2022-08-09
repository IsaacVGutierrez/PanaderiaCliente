using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Panaderia.BD.Migrations
{
    public partial class indices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cargos_EmpleadoId",
                table: "Cargos");

            migrationBuilder.DropIndex(
                name: "IX_Cargos_EncargadoId",
                table: "Cargos");

            migrationBuilder.CreateIndex(
                name: "EmpleadoCargoId_UQ",
                table: "Cargos",
                columns: new[] { "EmpleadoId", "Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "EncargadoCargoId_UQ",
                table: "Cargos",
                columns: new[] { "EncargadoId", "Id" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "EmpleadoCargoId_UQ",
                table: "Cargos");

            migrationBuilder.DropIndex(
                name: "EncargadoCargoId_UQ",
                table: "Cargos");

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_EmpleadoId",
                table: "Cargos",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_EncargadoId",
                table: "Cargos",
                column: "EncargadoId");
        }
    }
}
