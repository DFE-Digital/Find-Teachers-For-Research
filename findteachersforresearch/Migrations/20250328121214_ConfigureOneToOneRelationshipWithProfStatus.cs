using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureOneToOneRelationshipWithProfStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ProfStatus_PersonId",
                table: "ProfStatus",
                column: "PersonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfStatus_Persons_PersonId",
                table: "ProfStatus",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfStatus_Persons_PersonId",
                table: "ProfStatus");

            migrationBuilder.DropIndex(
                name: "IX_ProfStatus_PersonId",
                table: "ProfStatus");
        }
    }
}
