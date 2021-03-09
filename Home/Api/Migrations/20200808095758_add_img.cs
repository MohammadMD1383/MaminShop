using Microsoft.EntityFrameworkCore.Migrations;

namespace My_EShop_2.Migrations
{
    public partial class add_img : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageExtension",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageExtension",
                table: "Products");
        }
    }
}
