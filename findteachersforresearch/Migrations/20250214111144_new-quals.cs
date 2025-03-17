using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class newquals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProfStatus",
                columns: new[] { "Id", "ITTCourse", "ITTStartDate", "PersonId", "StatusName" },
                values: new object[,]
                {
                    { 12, "Latin", new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 12, "Qualified Teacher: By virtue of overseas qualifications" },
                    { 13, "Spanish", new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 13, "Qualified Teacher (Trained)" },
                    { 14, "Religion", new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 14, "Qualified Teacher (Trained)" }
                });

            migrationBuilder.InsertData(
                table: "Qualification",
                columns: new[] { "Id", "AwardDate", "Name", "PersonId" },
                values: new object[,]
                {
                    { 10, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2, 12 },
                    { 11, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2, 13 },
                    { 12, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2, 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
