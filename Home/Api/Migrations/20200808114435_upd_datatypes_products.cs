using Microsoft.EntityFrameworkCore.Migrations;

namespace My_EShop_2.Migrations
{
    public partial class upd_datatypes_products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "QuantityInStock",
                table: "Products",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,0)");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Products",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,0)",
                oldMaxLength: 300);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "QuantityInStock",
                table: "Products",
                type: "decimal(20,0)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(20,0)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 300);
        }
    }
}
