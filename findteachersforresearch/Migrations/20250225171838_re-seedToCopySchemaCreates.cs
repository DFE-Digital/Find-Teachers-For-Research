using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace findteachersforresearch.Migrations
{
    /// <inheritdoc />
    public partial class reseedToCopySchemaCreates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DateOfBirth", "EmailPersonal", "EmailWork", "FirstName", "Gender", "LastName", "Nino", "OptedOutOfResearch", "ReferenceNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 6, 23, 0, 0, 0, 0, DateTimeKind.Utc), "myles@gmail.com", "myles@work.com", "Myles", "Male", "Rabbit", "RAB54", false, "1234567" },
                    { 2, new DateTime(1985, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc), "jane@gmail.com", "jane@work.com", "Jane", "Female", "Smith", "SMI89", false, "7654321" },
                    { 3, new DateTime(1975, 9, 21, 0, 0, 0, 0, DateTimeKind.Utc), "doris@gmail.com", "doris@work.com", "Doris", "Female", "Madeline", "DMI869", true, "7678890" },
                    { 4, new DateTime(1989, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), "ronnie@gmail.com", "ronnie@work.com", "Ronnie", "Male", "Hotdogs", "RON345", false, "99888776" },
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
                    { -6, "Full Time", null, "7890", "Yorkshire", "Yorkshire Academy", "GIAS", "Open", "York", "Academies", "Academy", "123", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 5, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { -5, "Full Time", null, "4674", "Cornwall", "Stonelow School", "GIAS", "Open", "Helston", "Religious Schools", "Religious School", "223", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 4, new DateTime(2020, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { -4, "Full Time", null, "4545", "Lancashire", "All Saints School", "GIAS", "Open", "Lancaster", "Free Schools", "Free School", "567", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { -3, "Full Time", null, "9101", "Derbyshire", "Greenwood Academy", "GIAS", "Open", "Chesterfield", "Academies", "Academy", "925", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { -2, "Part Time Regular", null, "5678", "Derbyshire", "Holmesdale School", "GIAS", "Open", "Dronfield", "Local Authority Maintained Schools", "Foundation School", "925", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { -1, "Part Time Regular", null, "1234", "Derbyshire", "Gladys Buxton School", "GIAS", "Open", "Dronfield", "Local Authority Maintained Schools", "Foundation School", "925", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "ProfStatus",
                columns: new[] { "Id", "ITTCourse", "ITTStartDate", "PersonId", "StatusName" },
                values: new object[,]
                {
                    { 1, null, null, 1, 0 },
                    { 2, null, null, 2, 1 },
                    { 3, "Applied Physics", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, 2 },
                    { 4, "Geography", new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 4, 0 },
                    { 5, "Art", new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 5, 2 },
                    { 6, "French", new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 6, 2 },
                    { 7, "Biology", new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 7, 2 },
                    { 8, "Maths", new DateTime(2011, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 8, 0 },
                    { 9, "English", new DateTime(2008, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 9, 0 },
                    { 10, "Woodwork", new DateTime(2009, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 10, 0 },
                    { 11, "Metal Work", new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 11, 0 },
                    { 12, "Latin", new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 12, 0 },
                    { 13, "Spanish", new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 13, 0 },
                    { 14, "Religion", new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), 14, 0 }
                });

            migrationBuilder.InsertData(
                table: "Qualification",
                columns: new[] { "Id", "AwardDate", "Name", "PersonId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, 1 },
                    { 2, new DateTime(2017, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2, 2 },
                    { 4, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 0, 4 },
                    { 5, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 0, 8 },
                    { 6, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 0, 9 },
                    { 7, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 0, 10 },
                    { 8, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 0, 11 },
                    { 9, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2, 11 },
                    { 10, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2, 12 },
                    { 11, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2, 13 },
                    { 12, new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), 2, 14 }
                });

            migrationBuilder.InsertData(
                table: "ResearchRounds",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "Name", "Note", "PersonId", "Type" },
                values: new object[,]
                {
                    { 1, "will@education.gov.uk", new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Research to test if Feature X was a good one for newly qualified teachers.", "Teacher Vacancies New Feature X", "This is a note to say this research round is going to be great", 1, 1 },
                    { 2, "steph@education.gov.uk", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Research to test if Feature Y was a good one for qualified teachers with an NPQ.", "Teacher Vacancies New Feature Y", "This is a note to say this research round is going to be cold", 2, 0 }
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
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 4);

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
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProfStatus",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 4);

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
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Qualification",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ResearchRounds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ResearchRounds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

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
        }
    }
}
