using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeApp.API.Migrations
{
    public partial class EmployeeDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employment_start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    employment_end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Department", "Email", "First_name", "Gender", "Job_title", "Last_name", "Phone_number", "employment_end_date", "employment_start_date" },
                values: new object[,]
                {
                    { 1L, new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "uncle.bob@gmail.com", "Uncle", "male", "Solution architect", "Bob", "999-888-7777", new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(1981, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "jan.kirsten@gmail.com", "Jan", "male", "Solution architect", "Kirsten", "111-888-7777", new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(1982, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "James.Smith@gmail.com", "James", "male", "Technical architect", "Smith", "111-555-7777", new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(1986, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Selina.Chun@gmail.com", "Selina", "female", "Business Analyst", "Chun", "111-555-5555", new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new DateTime(1985, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Tracie.Chun@gmail.com", "Tracie", "female", "Business Analyst", "Chun", "2222-888-5555", new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
