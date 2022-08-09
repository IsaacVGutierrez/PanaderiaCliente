using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Panaderia.BD.Migrations
{
    public partial class diagrama : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Ventas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EncargadoId",
                table: "Proveedores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEntrega",
                table: "Proveedores",
                type: "datetime2",
                maxLength: 10,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Proveedores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VentaId",
                table: "Productos",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ProductoId",
                table: "Ventas",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_EncargadoId",
                table: "Proveedores",
                column: "EncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_ProductoId",
                table: "Proveedores",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_VentaId",
                table: "Productos",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Encargados_ProveedorId",
                table: "Encargados",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_VentaId",
                table: "Empleados",
                column: "VentaId");

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
                name: "FK_Productos_Ventas_VentaId",
                table: "Productos",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedores_Encargados_EncargadoId",
                table: "Proveedores",
                column: "EncargadoId",
                principalTable: "Encargados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedores_Productos_ProductoId",
                table: "Proveedores",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Empleados_ProductoId",
                table: "Ventas",
                column: "ProductoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Ventas_VentaId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Encargados_Proveedores_ProveedorId",
                table: "Encargados");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Ventas_VentaId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Proveedores_Encargados_EncargadoId",
                table: "Proveedores");

            migrationBuilder.DropForeignKey(
                name: "FK_Proveedores_Productos_ProductoId",
                table: "Proveedores");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Empleados_ProductoId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_ProductoId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Proveedores_EncargadoId",
                table: "Proveedores");

            migrationBuilder.DropIndex(
                name: "IX_Proveedores_ProductoId",
                table: "Proveedores");

            migrationBuilder.DropIndex(
                name: "IX_Productos_VentaId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Encargados_ProveedorId",
                table: "Encargados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_VentaId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "EncargadoId",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "FechaEntrega",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "VentaId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ProveedorId",
                table: "Encargados");

            migrationBuilder.DropColumn(
                name: "VentaId",
                table: "Empleados");
        }
    }
}
