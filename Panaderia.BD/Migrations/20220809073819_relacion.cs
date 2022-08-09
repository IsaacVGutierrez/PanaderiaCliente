using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Panaderia.BD.Migrations
{
    public partial class relacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomCargo",
                table: "Cargos",
                newName: "NombrCargo");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "Cargos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EncargadoId",
                table: "Cargos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_EmpleadoId",
                table: "Cargos",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_EncargadoId",
                table: "Cargos",
                column: "EncargadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargos_Empleados_EmpleadoId",
                table: "Cargos",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cargos_Encargados_EncargadoId",
                table: "Cargos",
                column: "EncargadoId",
                principalTable: "Encargados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargos_Empleados_EmpleadoId",
                table: "Cargos");

            migrationBuilder.DropForeignKey(
                name: "FK_Cargos_Encargados_EncargadoId",
                table: "Cargos");

            migrationBuilder.DropIndex(
                name: "IX_Cargos_EmpleadoId",
                table: "Cargos");

            migrationBuilder.DropIndex(
                name: "IX_Cargos_EncargadoId",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "EncargadoId",
                table: "Cargos");

            migrationBuilder.RenameColumn(
                name: "NombrCargo",
                table: "Cargos",
                newName: "NomCargo");
        }
    }
}
