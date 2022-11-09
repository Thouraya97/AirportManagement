using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class addannotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flight_plane_PlaneId",
                table: "flight");

            migrationBuilder.RenameColumn(
                name: "PlaneId",
                table: "flight",
                newName: "PlaneID");

            migrationBuilder.RenameIndex(
                name: "IX_flight_PlaneId",
                table: "flight",
                newName: "IX_flight_PlaneID");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "passenger",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "passenger",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Departure",
                table: "flight",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_flight_plane_PlaneID",
                table: "flight",
                column: "PlaneID",
                principalTable: "plane",
                principalColumn: "PlaneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flight_plane_PlaneID",
                table: "flight");

            migrationBuilder.RenameColumn(
                name: "PlaneID",
                table: "flight",
                newName: "PlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_flight_PlaneID",
                table: "flight",
                newName: "IX_flight_PlaneId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "passenger",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "passenger",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Departure",
                table: "flight",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_flight_plane_PlaneId",
                table: "flight",
                column: "PlaneId",
                principalTable: "plane",
                principalColumn: "PlaneId");
        }
    }
}
