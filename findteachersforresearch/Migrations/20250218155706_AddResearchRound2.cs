using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class AddResearchRound2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Research",
                keyColumn: "Id",
                keyValue: 2,
                column: "ResearchName",
                value: "Teacher Vacancies New Feature Y");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Research",
                keyColumn: "Id",
                keyValue: 2,
                column: "ResearchName",
                value: "TRS New Feature Y");
        }
    }
}
