using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class newpersonfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfessionalQualifications",
                table: "Persons",
                newName: "EmailWork");

            migrationBuilder.RenameColumn(
                name: "PlaceOfWork",
                table: "Persons",
                newName: "EmailPersonal");

            migrationBuilder.RenameColumn(
                name: "EstablishmnetTypeName",
                table: "Employment",
                newName: "EstablishmentTypeName");

            migrationBuilder.RenameColumn(
                name: "EstablishmnetTypeGroupName",
                table: "Employment",
                newName: "EstablishmentTypeGroupName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Employment",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: 2,
                column: "EndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EmailPersonal", "EmailWork" },
                values: new object[] { "myles@gmail.com", "myles@work.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailWork",
                table: "Persons",
                newName: "ProfessionalQualifications");

            migrationBuilder.RenameColumn(
                name: "EmailPersonal",
                table: "Persons",
                newName: "PlaceOfWork");

            migrationBuilder.RenameColumn(
                name: "EstablishmentTypeName",
                table: "Employment",
                newName: "EstablishmnetTypeName");

            migrationBuilder.RenameColumn(
                name: "EstablishmentTypeGroupName",
                table: "Employment",
                newName: "EstablishmnetTypeGroupName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Employment",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: 2,
                column: "EndDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PlaceOfWork", "ProfessionalQualifications" },
                values: new object[] { "Henry Fanshawe School", "QTS" });
        }
    }
}
