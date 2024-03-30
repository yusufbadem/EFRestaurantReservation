using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFRestaurantReservation.Migrations
{
    /// <inheritdoc />
    public partial class ReservationClassEdited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameSurname",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameSurname",
                table: "Reservations");
        }
    }
}
