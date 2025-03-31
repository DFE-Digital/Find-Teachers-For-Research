using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureOneToOneRelationshipWithPersonId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employment_Persons_PersonId",
                table: "Employment");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfStatus_Persons_PersonId",
                table: "ProfStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualification_Persons_PersonId",
                table: "Qualification");

            migrationBuilder.DropIndex(
                name: "IX_ProfStatus_PersonId",
                table: "ProfStatus");

            migrationBuilder.DropIndex(
                name: "IX_Employment_PersonId",
                table: "Employment");

            migrationBuilder.AlterColumn<string>(
                name: "PersonId",
                table: "Qualification",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "PersonId",
                table: "ProfStatus",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "PersonId1",
                table: "ProfStatus",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PersonId",
                table: "Employment",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "PersonId1",
                table: "Employment",
                type: "integer",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Persons_PersonId",
                table: "Persons",
                column: "PersonId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Qualification_Persons_PersonId",
                table: "Qualification",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employment_Persons_PersonId1",
                table: "Employment");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfStatus_Persons_PersonId1",
                table: "ProfStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualification_Persons_PersonId",
                table: "Qualification");

            migrationBuilder.DropIndex(
                name: "IX_ProfStatus_PersonId1",
                table: "ProfStatus");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Persons_PersonId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Employment_PersonId1",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "PersonId1",
                table: "ProfStatus");

            migrationBuilder.DropColumn(
                name: "PersonId1",
                table: "Employment");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Qualification",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "ProfStatus",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Employment",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateIndex(
                name: "IX_ProfStatus_PersonId",
                table: "ProfStatus",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Employment_PersonId",
                table: "Employment",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employment_Persons_PersonId",
                table: "Employment",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfStatus_Persons_PersonId",
                table: "ProfStatus",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualification_Persons_PersonId",
                table: "Qualification",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
