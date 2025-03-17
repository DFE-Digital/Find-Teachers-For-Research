using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class Migration_20250205 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    QTSAwardDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NPQAwardDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EYAwardDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    QTLSAwardDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfStatus", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProfStatus",
                columns: new[] { "Id", "EYAwardDate", "NPQAwardDate", "PersonId", "QTLSAwardDate", "QTSAwardDate", "StatusName" },
                values: new object[] { 1, null, null, 1, null, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Qualified Teacher (Trained)" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfStatus");
        }
    }
}
