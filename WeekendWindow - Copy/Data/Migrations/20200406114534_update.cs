using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class update : Migration
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
                values: new object[] { "3c9b707f-c118-4d11-bf0e-60702875d470", "4a680311-7873-4797-81fc-ec6739e1f6ed", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a590850d-fc67-4857-8074-284383250b5e", "2501a90f-9042-4139-8a2b-c1f444c4745d", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c9b707f-c118-4d11-bf0e-60702875d470");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a590850d-fc67-4857-8074-284383250b5e");

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
