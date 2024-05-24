using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Curlz.Migrations
{
    /// <inheritdoc />
    public partial class cd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Statuses_Booking_Id",
                table: "Statuses",
                column: "Booking_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Reg_Id",
                table: "Feedbacks",
                column: "Reg_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Service_Id",
                table: "Feedbacks",
                column: "Service_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Reg_Id",
                table: "Bookings",
                column: "Reg_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Service_Id",
                table: "Bookings",
                column: "Service_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Slot_Id",
                table: "Bookings",
                column: "Slot_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Registrations_Reg_Id",
                table: "Bookings",
                column: "Reg_Id",
                principalTable: "Registrations",
                principalColumn: "Reg_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Services_Service_Id",
                table: "Bookings",
                column: "Service_Id",
                principalTable: "Services",
                principalColumn: "Service_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Slots_Slot_Id",
                table: "Bookings",
                column: "Slot_Id",
                principalTable: "Slots",
                principalColumn: "Slot_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Registrations_Reg_Id",
                table: "Feedbacks",
                column: "Reg_Id",
                principalTable: "Registrations",
                principalColumn: "Reg_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Services_Service_Id",
                table: "Feedbacks",
                column: "Service_Id",
                principalTable: "Services",
                principalColumn: "Service_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_Bookings_Booking_Id",
                table: "Statuses",
                column: "Booking_Id",
                principalTable: "Bookings",
                principalColumn: "Booking_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Registrations_Reg_Id",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Services_Service_Id",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Slots_Slot_Id",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Registrations_Reg_Id",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Services_Service_Id",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_Bookings_Booking_Id",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Statuses_Booking_Id",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_Reg_Id",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_Service_Id",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_Reg_Id",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_Service_Id",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_Slot_Id",
                table: "Bookings");
        }
    }
}
