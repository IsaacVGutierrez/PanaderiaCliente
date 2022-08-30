using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Panaderia.BD.Migrations
{
    public partial class nuevo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCargo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Encargados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEncargado = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ApellidoEncargado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DNIEncargado = table.Column<int>(type: "int", maxLength: 9, nullable: false),
                    EdadEncargado = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    PuestoCargoEncargado = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TelefonoEncargado = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    DireccionEncargado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FechaInicioEncargado = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encargados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ApellidoEmpleado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DNIEmpleado = table.Column<int>(type: "int", maxLength: 9, nullable: false),
                    EdadEmpleado = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    TelefonoEmpleado = table.Column<long>(type: "bigint", maxLength: 12, nullable: false),
                    DireccionEmpleado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FechaContratoEmpleado = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleados_Cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoVenta = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    CantidadVenta = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    FechaVenta = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    CuotasVenta = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    InteresVenta = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    PrecioVenta = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ventas_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProduc = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PrecioProduc = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    CodigoProduc = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    FechaVencimientoProduc = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    CantidadProduc = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    VentaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProved = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DNIProved = table.Column<int>(type: "int", maxLength: 9, nullable: false),
                    DireccionProved = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TelefonoProved = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    FechaEntregaProved = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    EncargadoId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proveedores_Encargados_EncargadoId",
                        column: x => x.EncargadoId,
                        principalTable: "Encargados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedores_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "EmpleadoDNI_UQ",
                table: "Empleados",
                column: "DNIEmpleado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_CargoId",
                table: "Empleados",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "EncargadoDNI_UQ",
                table: "Encargados",
                column: "DNIEncargado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_VentaId",
                table: "Productos",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "ProductoCodigo_UQ",
                table: "Productos",
                column: "CodigoProduc",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_EncargadoId",
                table: "Proveedores",
                column: "EncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_ProductoId",
                table: "Proveedores",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "ProveedorDNI_UQ",
                table: "Proveedores",
                column: "DNIProved",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CodigoProducVenta_UQ",
                table: "Ventas",
                column: "CodigoVenta",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_EmpleadoId",
                table: "Ventas",
                column: "EmpleadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Encargados");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Cargos");
        }
    }
}
