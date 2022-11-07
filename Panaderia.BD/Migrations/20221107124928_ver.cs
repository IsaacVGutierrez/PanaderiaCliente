using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Panaderia.BD.Migrations
{
    public partial class ver : Migration
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
                    DNIEncargado = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    EdadEncargado = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    PuestoCargoEncargado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TelefonoEncargado = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DireccionEncargado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FechaInicioEncargado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
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
                    NombreEmpleado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ApellidoEmpleado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DNIEmpleado = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    EdadEmpleado = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    TelefonoEmpleado = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    DireccionEmpleado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FechaContratoEmpleado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
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
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProved = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DNIProved = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    DireccionProved = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TelefonoProved = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    FechaEntregaProved = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EncargadoId = table.Column<int>(type: "int", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProduc = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PrecioProduc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CodigoProduc = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FechaVencimientoProduc = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CantidadProduc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoVenta = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CantidadVenta = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FechaVenta = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CuotasVenta = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    InteresVenta = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PrecioVenta = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Ventas_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_CargoId",
                table: "Empleados",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ProveedorId",
                table: "Productos",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_EncargadoId",
                table: "Proveedores",
                column: "EncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_EmpleadoId",
                table: "Ventas",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ProductoId",
                table: "Ventas",
                column: "ProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Encargados");
        }
    }
}
