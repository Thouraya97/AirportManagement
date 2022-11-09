using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class ticketMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightPassenger");

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    seat = table.Column<int>(type: "int", nullable: false),
                    flightKey = table.Column<int>(type: "int", nullable: false),
                    passengerKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => new { x.seat, x.flightKey, x.passengerKey });
                    table.ForeignKey(
                        name: "FK_tickets_flight_flightKey",
                        column: x => x.flightKey,
                        principalTable: "flight",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tickets_passenger_passengerKey",
                        column: x => x.passengerKey,
                        principalTable: "passenger",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tickets_flightKey",
                table: "tickets",
                column: "flightKey");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_passengerKey",
                table: "tickets",
                column: "passengerKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.CreateTable(
                name: "FlightPassenger",
                columns: table => new
                {
                    FlightsFlightId = table.Column<int>(type: "int", nullable: false),
                    PassengersPassportNumber = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightPassenger", x => new { x.FlightsFlightId, x.PassengersPassportNumber });
                    table.ForeignKey(
                        name: "FK_FlightPassenger_flight_FlightsFlightId",
                        column: x => x.FlightsFlightId,
                        principalTable: "flight",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightPassenger_passenger_PassengersPassportNumber",
                        column: x => x.PassengersPassportNumber,
                        principalTable: "passenger",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_PassengersPassportNumber",
                table: "FlightPassenger",
                column: "PassengersPassportNumber");
        }
    }
}
