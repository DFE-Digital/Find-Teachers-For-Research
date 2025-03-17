using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class AddResearchRound : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResearchRounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchRounds", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 9,
                column: "StatusName",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 10,
                column: "StatusName",
                value: 0);

            migrationBuilder.InsertData(
                table: "ResearchRounds",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "will@education.gov.uk", new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Research to test if Feature X was a good one for newly qualified teachers.", "Teacher Vacancies New Feature X" },
                    { 2, "steph@education.gov.uk", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Research to test if Feature Y was a good one for qualified teachers with an NPQ.", "Teacher Vacancies New Feature Y" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResearchRounds");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 9,
                column: "StatusName",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 10,
                column: "StatusName",
                value: 1);
        }
    }
}
