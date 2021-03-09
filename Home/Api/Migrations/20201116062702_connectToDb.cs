using Microsoft.EntityFrameworkCore.Migrations;

namespace My_EShop_2.Migrations
{
    public partial class connectToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName", "RoleTitle" },
                values: new object[] { 2, "User", "کاربر" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName", "RoleTitle" },
                values: new object[] { 1, "Admin", "مدیر" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Password", "PhoneNumber", "RoleId", "UserName" },
                values: new object[] { 1, "aminkarvizi1384@gmail.com", "callofdutyblackops4", 0, 1, "aminq2w3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1);
        }
    }
}
