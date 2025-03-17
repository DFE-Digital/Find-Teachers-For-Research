using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class addemployment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    EstablishmentName = table.Column<string>(type: "text", nullable: false),
                    EstablishmnetTypeName = table.Column<string>(type: "text", nullable: false),
                    EstablishmnetTypeGroupName = table.Column<string>(type: "text", nullable: false),
                    EstablishmentTown = table.Column<string>(type: "text", nullable: false),
                    EstablishmentCounty = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastSeenInTPSDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmploymentType = table.Column<string>(type: "text", nullable: false),
                    EstablishmentCode = table.Column<string>(type: "text", nullable: false),
                    LaCode = table.Column<string>(type: "text", nullable: false),
                    EstablishmentStatus = table.Column<string>(type: "text", nullable: false),
                    EstablishmentSource = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employment_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employment",
                columns: new[] { "Id", "EmploymentType", "EndDate", "EstablishmentCode", "EstablishmentCounty", "EstablishmentName", "EstablishmentSource", "EstablishmentStatus", "EstablishmentTown", "EstablishmnetTypeGroupName", "EstablishmnetTypeName", "LaCode", "LastSeenInTPSDate", "PersonId", "StartDate" },
                values: new object[,]
                {
                    { 1, "Part Time Regular", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1234", "Derbyshire", "Gladys Buxton School", "GIAS", "Open", "Dronfield", "Local Authority MAintained Schools", "Foundation School", "925", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, "Part Time Regular", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5678", "Derbyshire", "Holmesdale School", "GIAS", "Open", "Dronfield", "Local Authority Maintained Schools", "Foundation School", "925", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employment_PersonId",
                table: "Employment",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employment");
        }
    }
}
