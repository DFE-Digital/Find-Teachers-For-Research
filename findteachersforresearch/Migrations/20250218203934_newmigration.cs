using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class newmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "StatusName",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "StatusName",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: 0);

            migrationBuilder.InsertData(
                table: "Qualification",
                columns: new[] { "Id", "AwardDate", "Name", "PersonId" },
                values: new object[] { 3, new DateTime(2010, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 0, 2 });
        }
    }
}
