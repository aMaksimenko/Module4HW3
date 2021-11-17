using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWork.Migrations
{
    public partial class AddClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    CountryFrom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "CountryFrom", "Email", "PhoneNumber", "Title" },
                values: new object[,]
                {
                    { 1, "USA", "firstBox@gmail.com", 111111, "Microsoft" },
                    { 2, "Germany", "secondBox@gmail.com", 222222, "Google" },
                    { 3, "Denmark", "third@gmail.com", 333333, "Apple" },
                    { 4, "Ukraine", "fourthBox@gmail.com", 444444, "Tesla" },
                    { 5, "Turkey", "fifthBox@gmail.com", 555555, "Amazon" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Budget", "ClientId", "Name", "StartedDate" },
                values: new object[,]
                {
                    { 1, 1000m, 1, "First project", new DateTime(2021, 11, 10, 15, 15, 24, 325, DateTimeKind.Local).AddTicks(4000) },
                    { 2, 1000m, 2, "Second project", new DateTime(2020, 4, 26, 15, 15, 24, 340, DateTimeKind.Local).AddTicks(3130) },
                    { 3, 1000m, 3, "Third project", new DateTime(2021, 8, 9, 15, 15, 24, 340, DateTimeKind.Local).AddTicks(3430) },
                    { 4, 1000m, 4, "Fourth project", new DateTime(2021, 9, 28, 15, 15, 24, 340, DateTimeKind.Local).AddTicks(3450) },
                    { 5, 1000m, 5, "Fifth project", new DateTime(2021, 5, 21, 15, 15, 24, 340, DateTimeKind.Local).AddTicks(3460) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Client_ClientId",
                table: "Projects",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Client_ClientId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ClientId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Projects");
        }
    }
}
