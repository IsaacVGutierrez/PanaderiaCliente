using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Panaderia.BD.Migrations
{
    public partial class ClaveUnica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "CodigoProducVenta_UQ",
                table: "Ventas",
                column: "CodigoProduc",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ProveedorDNI_UQ",
                table: "Proveedores",
                column: "DNI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ProductoCodigo_UQ",
                table: "Productos",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "EncargadoDNI_UQ",
                table: "Encargados",
                column: "DNI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "EmpleadoDNI_UQ",
                table: "Empleados",
                column: "DNI",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "CodigoProducVenta_UQ",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "ProveedorDNI_UQ",
                table: "Proveedores");

            migrationBuilder.DropIndex(
                name: "ProductoCodigo_UQ",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "EncargadoDNI_UQ",
                table: "Encargados");

            migrationBuilder.DropIndex(
                name: "EmpleadoDNI_UQ",
                table: "Empleados");
        }
    }
}
