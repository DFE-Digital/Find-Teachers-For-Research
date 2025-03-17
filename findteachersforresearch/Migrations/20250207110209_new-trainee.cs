using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class newtrainee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DateOfBirth", "EmailPersonal", "EmailWork", "FirstName", "LastName", "Nino", "ReferenceNumber" },
                values: new object[] { 3, new DateTime(1975, 9, 21, 0, 0, 0, 0, DateTimeKind.Utc), "doris@gmail.com", "doris@work.com", "Doris", "Madeline", "DMI869", "7678890" });

            migrationBuilder.InsertData(
                table: "Employment",
                columns: new[] { "Id", "EmploymentType", "EndDate", "EstablishmentCode", "EstablishmentCounty", "EstablishmentName", "EstablishmentSource", "EstablishmentStatus", "EstablishmentTown", "EstablishmentTypeGroupName", "EstablishmentTypeName", "LaCode", "LastSeenInTPSDate", "PersonId", "StartDate" },
                values: new object[] { 4, "Full Time", null, "4545", "Lancashire", "All Saints School", "GIAS", "Open", "Lancaster", "Free Schools", "Free School", "567", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "ProfStatus",
                columns: new[] { "Id", "PersonId", "StatusName" },
                values: new object[] { 3, 3, "Trainee" });

            migrationBuilder.InsertData(
                table: "Qualification",
                columns: new[] { "Id", "EYAwardDate", "NPQAwardDate", "PersonId", "QTLSAwardDate", "QTSAwardDate" },
                values: new object[] { 3, null, null, 3, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
