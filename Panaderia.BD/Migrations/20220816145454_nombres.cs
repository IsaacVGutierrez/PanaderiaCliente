using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Panaderia.BD.Migrations
{
    public partial class nombres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Proveedores",
                newName: "TelefonoProved");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Proveedores",
                newName: "NombreProved");

            migrationBuilder.RenameColumn(
                name: "FechaEntrega",
                table: "Proveedores",
                newName: "FechaEntregaProved");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Proveedores",
                newName: "DireccionProved");

            migrationBuilder.RenameColumn(
                name: "DNI",
                table: "Proveedores",
                newName: "DNIProved");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Productos",
                newName: "PrecioProduc");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Productos",
                newName: "NombreProduc");

            migrationBuilder.RenameColumn(
                name: "FechaVencimiento",
                table: "Productos",
                newName: "FechaVencimientoProduc");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "Productos",
                newName: "CodigoProduc");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Encargados",
                newName: "TelefonoEncargado");

            migrationBuilder.RenameColumn(
                name: "PuestoCargo",
                table: "Encargados",
                newName: "PuestoCargoEncargado");

            migrationBuilder.RenameColumn(
                name: "FechaInicio",
                table: "Encargados",
                newName: "FechaInicioEncargado");

            migrationBuilder.RenameColumn(
                name: "Edad",
                table: "Encargados",
                newName: "EdadEncargado");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Encargados",
                newName: "DireccionEncargado");

            migrationBuilder.RenameColumn(
                name: "DNI",
                table: "Encargados",
                newName: "DNIEncargado");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Empleados",
                newName: "TelefonoEmpleado");

            migrationBuilder.RenameColumn(
                name: "PuestoCargo",
                table: "Empleados",
                newName: "PuestoCargoEmpleado");

            migrationBuilder.RenameColumn(
                name: "FechaContrato",
                table: "Empleados",
                newName: "FechaContratoEmpleado");

            migrationBuilder.RenameColumn(
                name: "Edad",
                table: "Empleados",
                newName: "EdadEmpleado");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Empleados",
                newName: "DireccionEmpleado");

            migrationBuilder.RenameColumn(
                name: "DNI",
                table: "Empleados",
                newName: "DNIEmpleado");

            migrationBuilder.RenameColumn(
                name: "ApellidoEncargado",
                table: "Empleados",
                newName: "ApellidoEmpleado");

            migrationBuilder.RenameColumn(
                name: "NombrCargo",
                table: "Cargos",
                newName: "NombreCargo");

            migrationBuilder.AddColumn<int>(
                name: "CantidadProduc",
                table: "Productos",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadProduc",
                table: "Productos");

            migrationBuilder.RenameColumn(
                name: "TelefonoProved",
                table: "Proveedores",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "NombreProved",
                table: "Proveedores",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "FechaEntregaProved",
                table: "Proveedores",
                newName: "FechaEntrega");

            migrationBuilder.RenameColumn(
                name: "DireccionProved",
                table: "Proveedores",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "DNIProved",
                table: "Proveedores",
                newName: "DNI");

            migrationBuilder.RenameColumn(
                name: "PrecioProduc",
                table: "Productos",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "NombreProduc",
                table: "Productos",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "FechaVencimientoProduc",
                table: "Productos",
                newName: "FechaVencimiento");

            migrationBuilder.RenameColumn(
                name: "CodigoProduc",
                table: "Productos",
                newName: "Codigo");

            migrationBuilder.RenameColumn(
                name: "TelefonoEncargado",
                table: "Encargados",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "PuestoCargoEncargado",
                table: "Encargados",
                newName: "PuestoCargo");

            migrationBuilder.RenameColumn(
                name: "FechaInicioEncargado",
                table: "Encargados",
                newName: "FechaInicio");

            migrationBuilder.RenameColumn(
                name: "EdadEncargado",
                table: "Encargados",
                newName: "Edad");

            migrationBuilder.RenameColumn(
                name: "DireccionEncargado",
                table: "Encargados",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "DNIEncargado",
                table: "Encargados",
                newName: "DNI");

            migrationBuilder.RenameColumn(
                name: "TelefonoEmpleado",
                table: "Empleados",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "PuestoCargoEmpleado",
                table: "Empleados",
                newName: "PuestoCargo");

            migrationBuilder.RenameColumn(
                name: "FechaContratoEmpleado",
                table: "Empleados",
                newName: "FechaContrato");

            migrationBuilder.RenameColumn(
                name: "EdadEmpleado",
                table: "Empleados",
                newName: "Edad");

            migrationBuilder.RenameColumn(
                name: "DireccionEmpleado",
                table: "Empleados",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "DNIEmpleado",
                table: "Empleados",
                newName: "DNI");

            migrationBuilder.RenameColumn(
                name: "ApellidoEmpleado",
                table: "Empleados",
                newName: "ApellidoEncargado");

            migrationBuilder.RenameColumn(
                name: "NombreCargo",
                table: "Cargos",
                newName: "NombrCargo");
        }
    }
}
