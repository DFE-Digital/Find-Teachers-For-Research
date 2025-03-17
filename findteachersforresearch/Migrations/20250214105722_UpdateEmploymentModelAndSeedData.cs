using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmploymentModelAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Employment",
                columns: new[] { "Id", "EmploymentType", "EndDate", "EstablishmentCode", "EstablishmentCounty", "EstablishmentName", "EstablishmentSource", "EstablishmentStatus", "EstablishmentTown", "EstablishmentTypeGroupName", "EstablishmentTypeName", "LaCode", "LastSeenInTPSDate", "PersonId", "StartDate" },
                values: new object[,]
                {
                    { -5, "Full Time", null, "4674", "Cornwall", "Stonelow School", "GIAS", "Open", "Helston", "Religious Schools", "Religious School", "223", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 4, new DateTime(2020, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { -4, "Full Time", null, "4545", "Lancashire", "All Saints School", "GIAS", "Open", "Lancaster", "Free Schools", "Free School", "567", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { -3, "Full Time", null, "9101", "Derbyshire", "Greenwood Academy", "GIAS", "Open", "Chesterfield", "Academies", "Academy", "925", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { -2, "Part Time Regular", null, "5678", "Derbyshire", "Holmesdale School", "GIAS", "Open", "Dronfield", "Local Authority Maintained Schools", "Foundation School", "925", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { -1, "Part Time Regular", null, "1234", "Derbyshire", "Gladys Buxton School", "GIAS", "Open", "Dronfield", "Local Authority Maintained Schools", "Foundation School", "925", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DateOfBirth", "EmailPersonal", "EmailWork", "FirstName", "Gender", "LastName", "Nino", "OptedOutOfResearch", "ReferenceNumber" },
                values: new object[,]
                {
                    { 5, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "john.doe@gmail.com", "john.doe@work.com", "John", "Male", "Doe", "DOE123", false, "1111111" },
                    { 6, new DateTime(1992, 2, 14, 0, 0, 0, 0, DateTimeKind.Utc), "emily.clark@gmail.com", "emily.clark@work.com", "Emily", "Female", "Clark", "CLA456", false, "2222222" },
                    { 7, new DateTime(1978, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), "michael.brown@gmail.com", "michael.brown@work.com", "Michael", "Male", "Brown", "BRO789", false, "3333333" },
                    { 8, new DateTime(1995, 4, 30, 0, 0, 0, 0, DateTimeKind.Utc), "sarah.johnson@gmail.com", "sarah.johnson@work.com", "Sarah", "Female", "Johnson", "JOH012", false, "4444444" },
                    { 9, new DateTime(1983, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc), "david.wilson@gmail.com", "david.wilson@work.com", "David", "Male", "Wilson", "WIL345", false, "5555555" },
                    { 10, new DateTime(1987, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc), "laura.martinez@gmail.com", "laura.martinez@work.com", "Laura", "Female", "Martinez", "MAR678", false, "6666666" },
                    { 11, new DateTime(1991, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "james.anderson@gmail.com", "james.anderson@work.com", "James", "Male", "Anderson", "AND901", false, "7777777" },
                    { 12, new DateTime(1993, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), "sophia.lewis@gmail.com", "sophia.lewis@work.com", "Sophia", "Female", "Lewis", "LEW234", false, "8888888" },
                    { 13, new DateTime(1988, 9, 2, 0, 0, 0, 0, DateTimeKind.Utc), "robert.walker@gmail.com", "robert.walker@work.com", "Robert", "Male", "Walker", "WAL567", false, "9999999" },
                    { 14, new DateTime(1986, 10, 25, 0, 0, 0, 0, DateTimeKind.Utc), "olivia.harris@gmail.com", "olivia.harris@work.com", "Olivia", "Female", "Harris", "HAR890", false, "1010101" }
                });

            migrationBuilder.InsertData(
                table: "Employment",
                columns: new[] { "Id", "EmploymentType", "EndDate", "EstablishmentCode", "EstablishmentCounty", "EstablishmentName", "EstablishmentSource", "EstablishmentStatus", "EstablishmentTown", "EstablishmentTypeGroupName", "EstablishmentTypeName", "LaCode", "LastSeenInTPSDate", "PersonId", "StartDate" },
                values: new object[,]
                {
                    { -9, "Full Time", null, "1234", "Norfolk", "Norfolk Academy", "GIAS", "Open", "Norwich", "Academies", "Academy", "456", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 8, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { -8, "Full Time", null, "9012", "Lincolnshire", "Lincolnshire Academy", "GIAS", "Open", "York", "Academies", "Academy", "163", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 7, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { -7, "Part Time", null, "8901", "Hampshire", "Southampton Academy", "GIAS", "Open", "Southampton", "Academies", "Academy", "123", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 6, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { -6, "Full Time", null, "7890", "Yorkshire", "Yorkshire Academy", "GIAS", "Open", "York", "Academies", "Academy", "123", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 5, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "ProfStatus",
                columns: new[] { "Id", "ITTCourse", "ITTStartDate", "PersonId", "StatusName" },
                values: new object[,]
                {
                    { 5, "Art", new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 5, "Trainee" },
                    { 6, "French", new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 6, "Trainee" },
                    { 7, "Biology", new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 7, "Trainee" },
                    { 8, "Maths", new DateTime(2011, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 8, "Qualified Teacher (Trained)" },
                    { 9, "English", new DateTime(2008, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 9, "Qualified Teacher (Trained)" },
                    { 10, "Woodwork", new DateTime(2009, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 10, "Qualified Teacher (Trained)" },
                    { 11, "Metal Work", new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 11, "Qualified Teacher (Trained)" }
                });

            migrationBuilder.InsertData(
                table: "Qualification",
                columns: new[] { "Id", "AwardDate", "Name", "PersonId" },
                values: new object[,]
                {
                    { 5, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 0, 8 },
                    { 6, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 0, 9 },
                    { 7, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 0, 10 },
                    { 8, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 0, 11 },
                    { 9, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Employment",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.InsertData(
                table: "Employment",
                columns: new[] { "Id", "EmploymentType", "EndDate", "EstablishmentCode", "EstablishmentCounty", "EstablishmentName", "EstablishmentSource", "EstablishmentStatus", "EstablishmentTown", "EstablishmentTypeGroupName", "EstablishmentTypeName", "LaCode", "LastSeenInTPSDate", "PersonId", "StartDate" },
                values: new object[,]
                {
                    { 1, "Part Time Regular", null, "1234", "Derbyshire", "Gladys Buxton School", "GIAS", "Open", "Dronfield", "Local Authority Maintained Schools", "Foundation School", "925", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, "Part Time Regular", null, "5678", "Derbyshire", "Holmesdale School", "GIAS", "Open", "Dronfield", "Local Authority Maintained Schools", "Foundation School", "925", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, "Full Time", null, "9101", "Derbyshire", "Greenwood Academy", "GIAS", "Open", "Chesterfield", "Academies", "Academy", "925", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, "Full Time", null, "4545", "Lancashire", "All Saints School", "GIAS", "Open", "Lancaster", "Free Schools", "Free School", "567", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, "Full Time", null, "4674", "Cornwall", "Stonelow School", "GIAS", "Open", "Helston", "Religious Schools", "Religious School", "223", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 4, new DateTime(2020, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }
    }
}
