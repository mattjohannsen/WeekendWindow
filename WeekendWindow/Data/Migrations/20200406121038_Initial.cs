using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "204776c0-54f4-40dd-aefa-47ad70539127");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b286130f-9e0d-4671-97d4-f7ded38cb7dc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f207bdf6-863a-496a-8245-f981d7dd2277", "3e2393e9-92d0-4868-8c2a-8d9f891af033", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "067dc477-1dcb-4940-8cf2-76e0dacbb168", "53e1fef4-2d6d-413a-80e0-317c11e63ba5", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "067dc477-1dcb-4940-8cf2-76e0dacbb168");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f207bdf6-863a-496a-8245-f981d7dd2277");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b286130f-9e0d-4671-97d4-f7ded38cb7dc", "ff218d8a-bf9c-48e1-8f4d-51839f4e7e64", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "204776c0-54f4-40dd-aefa-47ad70539127", "46281ad6-4cab-4360-a445-8b016be898f1", "Viewer", "VIEWER" });
        }
    }
}
