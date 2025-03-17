using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePersonResearchRoundManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PersonResearchRound",
                columns: table => new
                {
                    PersonsId = table.Column<int>(type: "integer", nullable: false),
                    ResearchRoundsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonResearchRound", x => new { x.PersonsId, x.ResearchRoundsId });
                    table.ForeignKey(
                        name: "FK_PersonResearchRound_Persons_PersonsId",
                        column: x => x.PersonsId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonResearchRound_ResearchRounds_ResearchRoundsId",
                        column: x => x.ResearchRoundsId,
                        principalTable: "ResearchRounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonResearchRound_ResearchRoundsId",
                table: "PersonResearchRound",
                column: "ResearchRoundsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonResearchRound");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "ResearchRounds",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ResearchRounds_PersonId",
                table: "ResearchRounds",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchRounds_Persons_PersonId",
                table: "ResearchRounds",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
