using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class FixEmploymentPersonRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.DropForeignKey(
                name: "FK_ProfStatus_Persons_PersonId1",
                table: "ProfStatus");

            migrationBuilder.DropIndex(
                name: "IX_ProfStatus_PersonId1",
                table: "ProfStatus");

            migrationBuilder.DropIndex(
                name: "IX_Employment_PersonId1",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "PersonId1",
                table: "ProfStatus");

            migrationBuilder.DropColumn(
                name: "PersonId1",
                table: "Employment");

            migrationBuilder.RenameColumn(
                name: "EstablishmentPostcode",
                table: "Employment",
                newName: "EmployerPostcode");

            migrationBuilder.CreateIndex(
                name: "IX_Employment_PersonId",
                table: "Employment",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employment_Persons_PersonId",
                table: "Employment",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employment_Persons_PersonId",
                table: "Employment");

            migrationBuilder.DropIndex(
                name: "IX_Employment_PersonId",
                table: "Employment");

            migrationBuilder.RenameColumn(
                name: "EmployerPostcode",
                table: "Employment",
                newName: "EstablishmentPostcode");

            migrationBuilder.AddColumn<int>(
                name: "PersonId1",
                table: "ProfStatus",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId1",
                table: "Employment",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfStatus_PersonId1",
                table: "ProfStatus",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Employment_PersonId1",
                table: "Employment",
                column: "PersonId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employment_Persons_PersonId1",
                table: "Employment",
                column: "PersonId1",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfStatus_Persons_PersonId1",
                table: "ProfStatus",
                column: "PersonId1",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
