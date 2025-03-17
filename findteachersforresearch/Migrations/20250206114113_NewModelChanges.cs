using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class NewModelChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EYAwardDate",
                table: "ProfStatus");

            migrationBuilder.DropColumn(
                name: "NPQAwardDate",
                table: "ProfStatus");

            migrationBuilder.DropColumn(
                name: "QTLSAwardDate",
                table: "ProfStatus");

            migrationBuilder.DropColumn(
                name: "QTSAwardDate",
                table: "ProfStatus");

            migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                table: "ProfStatus",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "Qualification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    QTSAwardDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NPQAwardDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EYAwardDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    QTLSAwardDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Qualification_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Qualification",
                columns: new[] { "Id", "EYAwardDate", "NPQAwardDate", "PersonId", "QTLSAwardDate", "QTSAwardDate" },
                values: new object[] { 1, null, null, 1, null, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.CreateIndex(
                name: "IX_ProfStatus_PersonId",
                table: "ProfStatus",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_PersonId",
                table: "Qualification",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfStatus_Persons_PersonId",
                table: "ProfStatus",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfStatus_Persons_PersonId",
                table: "ProfStatus");

            migrationBuilder.DropTable(
                name: "Qualification");

            migrationBuilder.DropIndex(
                name: "IX_ProfStatus_PersonId",
                table: "ProfStatus");

            migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                table: "ProfStatus",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EYAwardDate",
                table: "ProfStatus",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NPQAwardDate",
                table: "ProfStatus",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "QTLSAwardDate",
                table: "ProfStatus",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "QTSAwardDate",
                table: "ProfStatus",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EYAwardDate", "NPQAwardDate", "QTLSAwardDate", "QTSAwardDate" },
                values: new object[] { null, null, null, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc) });
        }
    }
}
