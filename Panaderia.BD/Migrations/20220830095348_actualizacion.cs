using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Panaderia.BD.Migrations
{
    public partial class actualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargos_Encargados_EncargadoId",
                table: "Cargos");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Ventas_VentaId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Encargados_Proveedores_ProveedorId",
                table: "Encargados");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Empleados_ProductoId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Encargados_ProveedorId",
                table: "Encargados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_VentaId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "EncargadoCargoId_UQ",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "NombreProduc",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "ProveedorId",
                table: "Encargados");

            migrationBuilder.DropColumn(
                name: "VentaId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "EncargadoId",
                table: "Cargos");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "Ventas",
                newName: "EmpleadoId");

            migrationBuilder.RenameColumn(
                name: "PrecioProduc",
                table: "Ventas",
                newName: "PrecioVenta");

            migrationBuilder.RenameColumn(
                name: "CodigoProduc",
                table: "Ventas",
                newName: "CodigoVenta");

            migrationBuilder.RenameColumn(
                name: "CantidadProduc",
                table: "Ventas",
                newName: "CantidadVenta");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_ProductoId",
                table: "Ventas",
                newName: "IX_Ventas_EmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Empleados_EmpleadoId",
                table: "Ventas",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Empleados_EmpleadoId",
                table: "Ventas");

            migrationBuilder.RenameColumn(
                name: "PrecioVenta",
                table: "Ventas",
                newName: "PrecioProduc");

            migrationBuilder.RenameColumn(
                name: "EmpleadoId",
                table: "Ventas",
                newName: "ProductoId");

            migrationBuilder.RenameColumn(
                name: "CodigoVenta",
                table: "Ventas",
                newName: "CodigoProduc");

            migrationBuilder.RenameColumn(
                name: "CantidadVenta",
                table: "Ventas",
                newName: "CantidadProduc");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_EmpleadoId",
                table: "Ventas",
                newName: "IX_Ventas_ProductoId");

            migrationBuilder.AddColumn<string>(
                name: "NombreProduc",
                table: "Ventas",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProveedorId",
                table: "Encargados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VentaId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EncargadoId",
                table: "Cargos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Encargados_ProveedorId",
                table: "Encargados",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_VentaId",
                table: "Empleados",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "EncargadoCargoId_UQ",
                table: "Cargos",
                columns: new[] { "EncargadoId", "Id" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cargos_Encargados_EncargadoId",
                table: "Cargos",
                column: "EncargadoId",
                principalTable: "Encargados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Ventas_VentaId",
                table: "Empleados",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Encargados_Proveedores_ProveedorId",
                table: "Encargados",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Empleados_ProductoId",
                table: "Ventas",
                column: "ProductoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
