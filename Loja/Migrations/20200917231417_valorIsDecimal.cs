using Microsoft.EntityFrameworkCore.Migrations;

namespace Loja.Migrations
{
    public partial class valorIsDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Produtos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Valor",
                table: "Produtos",
                type: "VARCHAR(100)",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
