using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWork.Migrations
{
    public partial class Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employees",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Location", "Title" },
                values: new object[,]
                {
                    { 1, "Alekseevka", "Office #1" },
                    { 2, "Saltovka", "Office #3" },
                    { 3, "Bot Sad", "Office #5" }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2021, 11, 14, 13, 11, 51, 646, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2020, 4, 30, 13, 11, 51, 662, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2021, 8, 13, 13, 11, 51, 662, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartedDate",
                value: new DateTime(2021, 10, 2, 13, 11, 51, 662, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartedDate",
                value: new DateTime(2021, 5, 25, 13, 11, 51, 662, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Developer" },
                    { 2, "Manager" },
                    { 3, "QA" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "HiredDate", "LastName", "OfficeId", "TitleId" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marley", 1, 1 },
                    { 2, new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marley", 2, 1 },
                    { 5, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bill", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gates", 3, 2 },
                    { 3, new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ollof", 1, 3 },
                    { 4, new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arthur", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProjects",
                columns: new[] { "Id", "EmployeeId", "ProjectId", "Rate", "StartedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, 1000m, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 2, 3000m, new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 4, 55555m, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 3, 55555m, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 4, 5, 55555m, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeProjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeProjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeProjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeProjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employees",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2021, 11, 11, 8, 35, 33, 381, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2020, 4, 27, 8, 35, 33, 397, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2021, 8, 10, 8, 35, 33, 397, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartedDate",
                value: new DateTime(2021, 9, 29, 8, 35, 33, 397, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartedDate",
                value: new DateTime(2021, 5, 22, 8, 35, 33, 397, DateTimeKind.Local).AddTicks(6460));
        }
    }
}
