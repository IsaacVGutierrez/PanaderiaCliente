using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Panaderia.BD.Migrations
{
    public partial class cuotas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CuotasVenta",
                table: "Ventas",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CuotasVenta",
                table: "Ventas");
        }
    }
}
