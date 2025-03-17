using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class changeresearch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Research");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "ResearchRounds",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ResearchRounds",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ResearchRounds",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_ResearchRounds_PersonId",
                table: "ResearchRounds",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchRounds_Persons_PersonId",
                table: "ResearchRounds",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResearchRounds_Persons_PersonId",
                table: "ResearchRounds");

            migrationBuilder.DropIndex(
                name: "IX_ResearchRounds_PersonId",
                table: "ResearchRounds");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "ResearchRounds");

            migrationBuilder.CreateTable(
                name: "Research",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    ResearchDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ResearchName = table.Column<string>(type: "text", nullable: true),
                    UserResearcherName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Research", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Research_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "Id", "Notes", "PersonId", "ResearchDate", "ResearchName", "UserResearcherName" },
                values: new object[,]
                {
                    { 1, "Went really well.", 1, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Teacher Vacancies New Feature X", "Will@education.gov.uk" },
                    { 2, "Not a very engaged participant", 2, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Teacher Vacancies New Feature Y", "Steph@education.gov.uk" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Research_PersonId",
                table: "Research",
                column: "PersonId");
        }
    }
}
