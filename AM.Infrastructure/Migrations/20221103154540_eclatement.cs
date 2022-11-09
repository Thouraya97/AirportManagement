using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class eclatement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployementDate",
                table: "passenger");

            migrationBuilder.DropColumn(
                name: "Function",
                table: "passenger");

            migrationBuilder.DropColumn(
                name: "HealthInformation",
                table: "passenger");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "passenger");

            migrationBuilder.DropColumn(
                name: "PassengerTypeValue",
                table: "passenger");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "passenger");

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    PassportNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployementDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Function = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.PassportNumber);
                    table.ForeignKey(
                        name: "FK_Staff_passenger_PassportNumber",
                        column: x => x.PassportNumber,
                        principalTable: "passenger",
                        principalColumn: "PassportNumber");
                });

            migrationBuilder.CreateTable(
                name: "Traveller",
                columns: table => new
                {
                    PassportNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HealthInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traveller", x => x.PassportNumber);
                    table.ForeignKey(
                        name: "FK_Traveller_passenger_PassportNumber",
                        column: x => x.PassportNumber,
                        principalTable: "passenger",
                        principalColumn: "PassportNumber");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Traveller");

            migrationBuilder.AddColumn<DateTime>(
                name: "EmployementDate",
                table: "passenger",
                type: "DateTime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Function",
                table: "passenger",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HealthInformation",
                table: "passenger",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "passenger",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassengerTypeValue",
                table: "passenger",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "passenger",
                type: "float",
                nullable: true);
        }
    }
}
