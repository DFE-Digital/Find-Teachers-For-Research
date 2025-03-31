using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class updatedmodelspostdatachanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwardDate",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "ITTCourse",
                table: "ProfStatus");

            migrationBuilder.DropColumn(
                name: "ITTStartDate",
                table: "ProfStatus");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "EstablishmentCode",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "EstablishmentCounty",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "EstablishmentTown",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "EstablishmentTypeName",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "LaCode",
                table: "Employment");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Qualification",
                newName: "NPQSL");

            migrationBuilder.AddColumn<DateTime>(
                name: "EYTSDate",
                table: "Qualification",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MQ",
                table: "Qualification",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NPQEL",
                table: "Qualification",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NPQH",
                table: "Qualification",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NPQLBC",
                table: "Qualification",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NPQLTD",
                table: "Qualification",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NPQML",
                table: "Qualification",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "QTSDate",
                table: "Qualification",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EstablishmentTypeGroupName",
                table: "Employment",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "EstablishmentStatus",
                table: "Employment",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "EstablishmentSource",
                table: "Employment",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "EstablishmentName",
                table: "Employment",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "EstablishmentPostcode",
                table: "Employment",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExtractDate",
                table: "Employment",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "FSMPercentage",
                table: "Employment",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPupils",
                table: "Employment",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhaseOfEducation",
                table: "Employment",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Urn",
                table: "Employment",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WithdrawalConfirmed",
                table: "Employment",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EYTSDate",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "MQ",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "NPQEL",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "NPQH",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "NPQLBC",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "NPQLTD",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "NPQML",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "QTSDate",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "EstablishmentPostcode",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "ExtractDate",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "FSMPercentage",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "NumberOfPupils",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "PhaseOfEducation",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "Urn",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "WithdrawalConfirmed",
                table: "Employment");

            migrationBuilder.RenameColumn(
                name: "NPQSL",
                table: "Qualification",
                newName: "Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "AwardDate",
                table: "Qualification",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Persons",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "EstablishmentTypeGroupName",
                table: "Employment",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EstablishmentStatus",
                table: "Employment",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EstablishmentSource",
                table: "Employment",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EstablishmentName",
                table: "Employment",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstablishmentCode",
                table: "Employment",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EstablishmentCounty",
                table: "Employment",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EstablishmentTown",
                table: "Employment",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EstablishmentTypeName",
                table: "Employment",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LaCode",
                table: "Employment",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
