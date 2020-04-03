using Microsoft.EntityFrameworkCore.Migrations;

namespace WeekendWindow.Data.Migrations
{
    public partial class warriorInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c40beea-a3e6-42e3-9e90-1574d555fabb");

            migrationBuilder.CreateTable(
                name: "Warriors",
                columns: table => new
                {
                    WarriorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityUserId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zipcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warriors", x => x.WarriorId);
                    table.ForeignKey(
                        name: "FK_Warriors_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef65f9b7-eb1e-4654-b9d4-d03f1935f6fc", "32f3c07b-9664-4c72-8109-b7c3cf22f4a9", "Warrior", "WARRIOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Warriors_IdentityUserId",
                table: "Warriors",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warriors");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef65f9b7-eb1e-4654-b9d4-d03f1935f6fc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c40beea-a3e6-42e3-9e90-1574d555fabb", "b4a6e2de-a0f4-4cde-8c75-c62eba351211", "Warrior", "WARRIOR" });
        }
    }
}
