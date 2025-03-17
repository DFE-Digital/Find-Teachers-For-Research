using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class UpdateQualificationToEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EYAwardDate",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "NPQAwardDate",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "QTLSAwardDate",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "QTSAwardDate",
                table: "Qualification");

            migrationBuilder.AddColumn<DateTime>(
                name: "AwardDate",
                table: "Qualification",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "Qualification",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AwardDate", "Name" },
                values: new object[] { new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0 });

            migrationBuilder.UpdateData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AwardDate", "Name" },
                values: new object[] { new DateTime(2017, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.UpdateData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AwardDate", "Name", "PersonId" },
                values: new object[] { new DateTime(2010, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 0, 2 });

            migrationBuilder.UpdateData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AwardDate", "Name" },
                values: new object[] { new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwardDate",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Qualification");

            migrationBuilder.AddColumn<DateTime>(
                name: "EYAwardDate",
                table: "Qualification",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NPQAwardDate",
                table: "Qualification",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "QTLSAwardDate",
                table: "Qualification",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "QTSAwardDate",
                table: "Qualification",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EYAwardDate", "NPQAwardDate", "QTLSAwardDate", "QTSAwardDate" },
                values: new object[] { null, null, null, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EYAwardDate", "NPQAwardDate", "QTLSAwardDate", "QTSAwardDate" },
                values: new object[] { new DateTime(2017, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, null, new DateTime(2010, 4, 25, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EYAwardDate", "NPQAwardDate", "PersonId", "QTLSAwardDate", "QTSAwardDate" },
                values: new object[] { null, null, 3, null, null });

            migrationBuilder.UpdateData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EYAwardDate", "NPQAwardDate", "QTLSAwardDate", "QTSAwardDate" },
                values: new object[] { null, null, null, new DateTime(2009, 4, 25, 0, 0, 0, 0, DateTimeKind.Utc) });
        }
    }
}
