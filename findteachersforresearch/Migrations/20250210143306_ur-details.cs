using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class urdetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "OptedOutOfResearch",
                table: "Persons",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Research",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Notes", "UserResearcherName" },
                values: new object[] { "Went really well.", "Will@education.goc.uk" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "OptedOutOfResearch",
                table: "Persons",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.UpdateData(
                table: "Research",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Notes", "UserResearcherName" },
                values: new object[] { null, null });
        }
    }
}
