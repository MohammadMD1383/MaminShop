using Microsoft.EntityFrameworkCore.Migrations;

namespace My_EShop_2.Migrations
{
    public partial class upd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Count",
                table: "CartItems",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Count",
                table: "CartItems",
                type: "decimal(20,0)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
