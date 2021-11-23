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

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "BirthDate", "FullName", "Program", "ProgramYear" },
                values: new object[] { 1, new DateTime(2021, 11, 23, 13, 20, 56, 605, DateTimeKind.Local).AddTicks(5891), "Zach McIntosh", "Cyber", 2 });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "BirthDate", "FullName", "Program", "ProgramYear" },
                values: new object[] { 2, new DateTime(2021, 11, 23, 13, 20, 56, 608, DateTimeKind.Local).AddTicks(3928), "Ben Hicks", "Software", 2 });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "BirthDate", "FullName", "Program", "ProgramYear" },
                values: new object[] { 3, new DateTime(2021, 11, 23, 13, 20, 56, 608, DateTimeKind.Local).AddTicks(4048), "Colby Nolasco", "Software", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
