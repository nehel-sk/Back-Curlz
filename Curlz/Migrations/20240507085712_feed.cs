using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Curlz.Migrations
{
    /// <inheritdoc />
    public partial class feed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Services_Service_Id",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_Service_Id",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Service_Id",
                table: "Feedbacks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Service_Id",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Service_Id",
                table: "Feedbacks",
                column: "Service_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Services_Service_Id",
                table: "Feedbacks",
                column: "Service_Id",
                principalTable: "Services",
                principalColumn: "Service_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
