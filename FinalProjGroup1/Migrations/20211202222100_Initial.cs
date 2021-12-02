using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjGroup1.Migrations
{
    public partial class Initial : Migration
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

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "BirthDate", "FullName", "Program", "ProgramYear" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 2, 17, 21, 0, 159, DateTimeKind.Local).AddTicks(549), "Zach McIntosh", "Cyber", 2 },
                    { 2, new DateTime(2021, 12, 2, 17, 21, 0, 162, DateTimeKind.Local).AddTicks(4104), "Ben Hicks", "Software", 2 },
                    { 3, new DateTime(2021, 12, 2, 17, 21, 0, 162, DateTimeKind.Local).AddTicks(4256), "Colby Nolasco", "Software", 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentFood",
                columns: new[] { "Id", "Breakfast", "Dinner", "FullName", "Lunch" },
                values: new object[] { 1, "Poptarts", "Chicken", "Colby Nolasco", "Hot Pockets" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "StudentFood");
        }
    }
}
