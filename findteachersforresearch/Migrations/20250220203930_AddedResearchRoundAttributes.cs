using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class AddedResearchRoundAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "ResearchRounds",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "ResearchRounds",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ResearchRounds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Note", "Type" },
                values: new object[] { "This is a note to say this research round is going to be great", 1 });

            migrationBuilder.UpdateData(
                table: "ResearchRounds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Note", "Type" },
                values: new object[] { "This is a note to say this research round is going to be cold", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "ResearchRounds");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "ResearchRounds");
        }
    }
}
