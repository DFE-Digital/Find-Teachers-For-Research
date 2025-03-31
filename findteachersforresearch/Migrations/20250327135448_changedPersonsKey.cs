using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class changedPersonsKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Qualification_PersonId",
                table: "Qualification");

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_PersonId",
                table: "Qualification",
                column: "PersonId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Qualification_PersonId",
                table: "Qualification");

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_PersonId",
                table: "Qualification",
                column: "PersonId");
        }
    }
}
