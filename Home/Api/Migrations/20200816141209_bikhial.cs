using Microsoft.EntityFrameworkCore.Migrations;

namespace My_EShop_2.Migrations
{
    public partial class bikhial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SumOfPrice",
                table: "Carts",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SumOfPrice",
                table: "Carts",
                type: "decimal(20,0)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
