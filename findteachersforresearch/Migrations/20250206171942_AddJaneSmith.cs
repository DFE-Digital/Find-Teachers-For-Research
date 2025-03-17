using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class AddJaneSmith : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstablishmentTypeGroupName",
                value: "Local Authority Maintained Schools");

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DateOfBirth", "EmailPersonal", "EmailWork", "FirstName", "LastName", "Nino", "ReferenceNumber" },
                values: new object[] { 2, new DateTime(1985, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc), "jane@gmail.com", "jane@work.com", "Jane", "Smith", "SMI89", "7654321" });

            migrationBuilder.InsertData(
                table: "Employment",
                columns: new[] { "Id", "EmploymentType", "EndDate", "EstablishmentCode", "EstablishmentCounty", "EstablishmentName", "EstablishmentSource", "EstablishmentStatus", "EstablishmentTown", "EstablishmentTypeGroupName", "EstablishmentTypeName", "LaCode", "LastSeenInTPSDate", "PersonId", "StartDate" },
                values: new object[] { 3, "Full Time", null, "9101", "Derbyshire", "Greenwood Academy", "GIAS", "Open", "Chesterfield", "Academies", "Academy", "925", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "ProfStatus",
                columns: new[] { "Id", "PersonId", "StatusName" },
                values: new object[] { 2, 2, "Qualified Teacher: By virtue of overseas qualifications" });

            migrationBuilder.InsertData(
                table: "Qualification",
                columns: new[] { "Id", "EYAwardDate", "NPQAwardDate", "PersonId", "QTLSAwardDate", "QTSAwardDate" },
                values: new object[] { 2, new DateTime(2017, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, 2, null, new DateTime(2010, 4, 25, 0, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstablishmentTypeGroupName",
                value: "Local Authority MAintained Schools");
        }
    }
}
