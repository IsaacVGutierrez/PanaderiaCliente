using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Panaderia.BD.Migrations
{
    public partial class FechaCreacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaVenta",
                table: "Ventas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaVencimiento",
                table: "Productos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Edad",
                table: "Encargados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInicio",
                table: "Encargados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Edad",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaContrato",
                table: "Empleados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaVenta",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "FechaVencimiento",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Encargados");

            migrationBuilder.DropColumn(
                name: "FechaInicio",
                table: "Encargados");

            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "FechaContrato",
                table: "Empleados");
        }
    }
}
