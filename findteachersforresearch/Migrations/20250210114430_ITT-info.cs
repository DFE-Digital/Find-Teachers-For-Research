using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class ITTinfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ITTCourse",
                table: "ProfStatus",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ITTStartDate",
                table: "ProfStatus",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ITTCourse", "ITTStartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ITTCourse", "ITTStartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ITTCourse", "ITTStartDate" },
                values: new object[] { "Applied Physics", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ITTCourse",
                table: "ProfStatus");

            migrationBuilder.DropColumn(
                name: "ITTStartDate",
                table: "ProfStatus");
        }
    }
}
