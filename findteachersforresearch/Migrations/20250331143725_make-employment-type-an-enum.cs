using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class makeemploymenttypeanenum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmploymentType",
                table: "Employment");

            migrationBuilder.AddColumn<int>(
                name: "EmploymentTypeName",
                table: "Employment",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmploymentTypeName",
                table: "Employment");

            migrationBuilder.AddColumn<string>(
                name: "EmploymentType",
                table: "Employment",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
