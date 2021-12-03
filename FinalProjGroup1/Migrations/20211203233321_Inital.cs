using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjGroup1.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Program = table.Column<string>(nullable: true),
                    ProgramYear = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentCar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentName = table.Column<string>(nullable: true),
                    carMake = table.Column<string>(nullable: true),
                    carModel = table.Column<string>(nullable: true),
                    carYear = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentFood",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Breakfast = table.Column<string>(nullable: true),
                    Lunch = table.Column<string>(nullable: true),
                    Dinner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentFood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentGame",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatorName = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGame", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "BirthDate", "FullName", "Program", "ProgramYear" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 3, 18, 33, 21, 491, DateTimeKind.Local).AddTicks(4772), "Zach McIntosh", "Cyber", 2 },
                    { 2, new DateTime(2021, 12, 3, 18, 33, 21, 494, DateTimeKind.Local).AddTicks(5492), "Ben Hicks", "Software", 2 },
                    { 3, new DateTime(2021, 12, 3, 18, 33, 21, 494, DateTimeKind.Local).AddTicks(5629), "Colby Nolasco", "Software", 3 },
                    { 4, new DateTime(2021, 12, 3, 18, 33, 21, 494, DateTimeKind.Local).AddTicks(5639), "Saif Bayyari", "Software", 2 }
                });

            migrationBuilder.InsertData(
                table: "StudentCar",
                columns: new[] { "Id", "carMake", "carModel", "carYear", "studentName" },
                values: new object[] { 1, "Nissan", "200 SX", "1998", "Saif Bayyari" });

            migrationBuilder.InsertData(
                table: "StudentFood",
                columns: new[] { "Id", "Breakfast", "Dinner", "FullName", "Lunch" },
                values: new object[] { 1, "Poptarts", "Chicken", "Colby Nolasco", "Hot Pockets" });

            migrationBuilder.InsertData(
                table: "StudentGame",
                columns: new[] { "Id", "CreatorName", "Genre", "Title", "Version" },
                values: new object[] { 1, "NinjaKiwi", "Strategy", "Bloons TD 6", "28.3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "StudentCar");

            migrationBuilder.DropTable(
                name: "StudentFood");

            migrationBuilder.DropTable(
                name: "StudentGame");
        }
    }
}
