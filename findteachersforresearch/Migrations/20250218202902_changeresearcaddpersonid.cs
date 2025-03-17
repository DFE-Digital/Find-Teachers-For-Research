using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class changeresearcaddpersonid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResearchRounds_Persons_PersonId",
                table: "ResearchRounds");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "ResearchRounds",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ResearchRounds",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ResearchRounds",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonId",
                value: 2);

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchRounds_Persons_PersonId",
                table: "ResearchRounds",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResearchRounds_Persons_PersonId",
                table: "ResearchRounds");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "ResearchRounds",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ResearchRounds_Persons_PersonId",
                table: "ResearchRounds",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
