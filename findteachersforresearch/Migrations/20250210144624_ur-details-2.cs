using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class urdetails2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Research",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserResearcherName",
                value: "Will@education.gov.uk");

            migrationBuilder.UpdateData(
                table: "Research",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Notes", "ResearchDate", "ResearchName", "UserResearcherName" },
                values: new object[] { "Not a very engaged participant", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), "TRS New Feature Y", "Steph@education.gov.uk" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Research",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserResearcherName",
                value: "Will@education.goc.uk");

            migrationBuilder.UpdateData(
                table: "Research",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Notes", "ResearchDate", "ResearchName", "UserResearcherName" },
                values: new object[] { null, null, null, null });
        }
    }
}
