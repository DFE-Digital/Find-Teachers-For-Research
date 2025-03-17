using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class research : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OptedOutOfResearch",
                table: "Persons",
                type: "boolean",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Research",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    ResearchDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserResearcherName = table.Column<string>(type: "text", nullable: true),
                    ResearchName = table.Column<string>(type: "text", nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true)
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

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "OptedOutOfResearch",
                value: false);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "OptedOutOfResearch",
                value: false);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "OptedOutOfResearch",
                value: true);

            migrationBuilder.InsertData(
                table: "Research",
                columns: new[] { "Id", "Notes", "PersonId", "ResearchDate", "ResearchName", "UserResearcherName" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Teacher Vacancies New Feature X", null },
                    { 2, null, 2, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Research_PersonId",
                table: "Research",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Research");

            migrationBuilder.DropColumn(
                name: "OptedOutOfResearch",
                table: "Persons");
        }
    }
}
