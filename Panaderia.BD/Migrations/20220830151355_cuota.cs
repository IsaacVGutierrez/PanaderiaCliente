using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Panaderia.BD.Migrations
{
    public partial class cuota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InteresVenta",
                table: "Ventas",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InteresVenta",
                table: "Ventas");
        }
    }
}
