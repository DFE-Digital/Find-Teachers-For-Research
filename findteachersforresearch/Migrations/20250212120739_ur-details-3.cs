using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class urdetails3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DateOfBirth", "EmailPersonal", "EmailWork", "FirstName", "Gender", "LastName", "Nino", "OptedOutOfResearch", "ReferenceNumber" },
                values: new object[] { 4, new DateTime(1989, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), "ronnie@gmail.com", "ronnie@work.com", "Ronnie", "Male", "Hotdogs", "RON345", false, "99888776" });

            migrationBuilder.InsertData(
                table: "Employment",
                columns: new[] { "Id", "EmploymentType", "EndDate", "EstablishmentCode", "EstablishmentCounty", "EstablishmentName", "EstablishmentSource", "EstablishmentStatus", "EstablishmentTown", "EstablishmentTypeGroupName", "EstablishmentTypeName", "LaCode", "LastSeenInTPSDate", "PersonId", "StartDate" },
                values: new object[] { 5, "Full Time", null, "4674", "Cornwall", "Stonelow School", "GIAS", "Open", "Helston", "Religious Schools", "Religious School", "223", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 4, new DateTime(2020, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "ProfStatus",
                columns: new[] { "Id", "ITTCourse", "ITTStartDate", "PersonId", "StatusName" },
                values: new object[] { 4, "Geography", new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 4, "Qualified Teacher (Trained)" });

            migrationBuilder.InsertData(
                table: "Qualification",
                columns: new[] { "Id", "EYAwardDate", "NPQAwardDate", "PersonId", "QTLSAwardDate", "QTSAwardDate" },
                values: new object[] { 4, null, null, 4, null, new DateTime(2009, 4, 25, 0, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
