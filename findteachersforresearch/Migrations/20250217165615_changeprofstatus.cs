using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class changeprofstatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusName_New",
                table: "ProfStatus",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.Sql(@"
                UPDATE ""ProfStatus"" 
                SET ""StatusName_New"" = CASE ""StatusName""
                    WHEN 'Qualified Teacher (Trained)' THEN 0
                    WHEN 'Qualified Teacher: By virtue of overseas qualifications' THEN 1
                    WHEN 'Trainee' THEN 2
                    ELSE 0
                END");

            migrationBuilder.DropColumn(
                name: "StatusName",
                table: "ProfStatus");

            migrationBuilder.RenameColumn(
                name: "StatusName_New",
                table: "ProfStatus",
                newName: "StatusName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                table: "ProfStatus",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "StatusName",
                value: "Qualified Teacher (Trained)");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "StatusName",
                value: "Qualified Teacher: By virtue of overseas qualifications");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 3,
                column: "StatusName",
                value: "Trainee");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 4,
                column: "StatusName",
                value: "Qualified Teacher (Trained)");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 5,
                column: "StatusName",
                value: "Trainee");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 6,
                column: "StatusName",
                value: "Trainee");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 7,
                column: "StatusName",
                value: "Trainee");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 8,
                column: "StatusName",
                value: "Qualified Teacher (Trained)");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 9,
                column: "StatusName",
                value: "Qualified Teacher (Trained)");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 10,
                column: "StatusName",
                value: "Qualified Teacher (Trained)");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 11,
                column: "StatusName",
                value: "Qualified Teacher (Trained)");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 12,
                column: "StatusName",
                value: "Qualified Teacher: By virtue of overseas qualifications");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 13,
                column: "StatusName",
                value: "Qualified Teacher (Trained)");

            migrationBuilder.UpdateData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 14,
                column: "StatusName",
                value: "Qualified Teacher (Trained)");
        }
    }
}
