﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using findteachersforresearch.Data;

#nullable disable

namespace findteachersforresearch.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250225171838_re-seedToCopySchemaCreates")]
    partial class reseedToCopySchemaCreates
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("findteachersforresearch.Models.Employment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EmploymentType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EstablishmentCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EstablishmentCounty")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EstablishmentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EstablishmentSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EstablishmentStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EstablishmentTown")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EstablishmentTypeGroupName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EstablishmentTypeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LaCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LastSeenInTPSDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Employment");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            EmploymentType = "Part Time Regular",
                            EstablishmentCode = "1234",
                            EstablishmentCounty = "Derbyshire",
                            EstablishmentName = "Gladys Buxton School",
                            EstablishmentSource = "GIAS",
                            EstablishmentStatus = "Open",
                            EstablishmentTown = "Dronfield",
                            EstablishmentTypeGroupName = "Local Authority Maintained Schools",
                            EstablishmentTypeName = "Foundation School",
                            LaCode = "925",
                            LastSeenInTPSDate = new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 1,
                            StartDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -2,
                            EmploymentType = "Part Time Regular",
                            EstablishmentCode = "5678",
                            EstablishmentCounty = "Derbyshire",
                            EstablishmentName = "Holmesdale School",
                            EstablishmentSource = "GIAS",
                            EstablishmentStatus = "Open",
                            EstablishmentTown = "Dronfield",
                            EstablishmentTypeGroupName = "Local Authority Maintained Schools",
                            EstablishmentTypeName = "Foundation School",
                            LaCode = "925",
                            LastSeenInTPSDate = new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 1,
                            StartDate = new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -3,
                            EmploymentType = "Full Time",
                            EstablishmentCode = "9101",
                            EstablishmentCounty = "Derbyshire",
                            EstablishmentName = "Greenwood Academy",
                            EstablishmentSource = "GIAS",
                            EstablishmentStatus = "Open",
                            EstablishmentTown = "Chesterfield",
                            EstablishmentTypeGroupName = "Academies",
                            EstablishmentTypeName = "Academy",
                            LaCode = "925",
                            LastSeenInTPSDate = new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 2,
                            StartDate = new DateTime(2018, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -4,
                            EmploymentType = "Full Time",
                            EstablishmentCode = "4545",
                            EstablishmentCounty = "Lancashire",
                            EstablishmentName = "All Saints School",
                            EstablishmentSource = "GIAS",
                            EstablishmentStatus = "Open",
                            EstablishmentTown = "Lancaster",
                            EstablishmentTypeGroupName = "Free Schools",
                            EstablishmentTypeName = "Free School",
                            LaCode = "567",
                            LastSeenInTPSDate = new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 3,
                            StartDate = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -5,
                            EmploymentType = "Full Time",
                            EstablishmentCode = "4674",
                            EstablishmentCounty = "Cornwall",
                            EstablishmentName = "Stonelow School",
                            EstablishmentSource = "GIAS",
                            EstablishmentStatus = "Open",
                            EstablishmentTown = "Helston",
                            EstablishmentTypeGroupName = "Religious Schools",
                            EstablishmentTypeName = "Religious School",
                            LaCode = "223",
                            LastSeenInTPSDate = new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 4,
                            StartDate = new DateTime(2020, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -6,
                            EmploymentType = "Full Time",
                            EstablishmentCode = "7890",
                            EstablishmentCounty = "Yorkshire",
                            EstablishmentName = "Yorkshire Academy",
                            EstablishmentSource = "GIAS",
                            EstablishmentStatus = "Open",
                            EstablishmentTown = "York",
                            EstablishmentTypeGroupName = "Academies",
                            EstablishmentTypeName = "Academy",
                            LaCode = "123",
                            LastSeenInTPSDate = new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 5,
                            StartDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -7,
                            EmploymentType = "Part Time",
                            EstablishmentCode = "8901",
                            EstablishmentCounty = "Hampshire",
                            EstablishmentName = "Southampton Academy",
                            EstablishmentSource = "GIAS",
                            EstablishmentStatus = "Open",
                            EstablishmentTown = "Southampton",
                            EstablishmentTypeGroupName = "Academies",
                            EstablishmentTypeName = "Academy",
                            LaCode = "123",
                            LastSeenInTPSDate = new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 6,
                            StartDate = new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -8,
                            EmploymentType = "Full Time",
                            EstablishmentCode = "9012",
                            EstablishmentCounty = "Lincolnshire",
                            EstablishmentName = "Lincolnshire Academy",
                            EstablishmentSource = "GIAS",
                            EstablishmentStatus = "Open",
                            EstablishmentTown = "York",
                            EstablishmentTypeGroupName = "Academies",
                            EstablishmentTypeName = "Academy",
                            LaCode = "163",
                            LastSeenInTPSDate = new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 7,
                            StartDate = new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = -9,
                            EmploymentType = "Full Time",
                            EstablishmentCode = "1234",
                            EstablishmentCounty = "Norfolk",
                            EstablishmentName = "Norfolk Academy",
                            EstablishmentSource = "GIAS",
                            EstablishmentStatus = "Open",
                            EstablishmentTown = "Norwich",
                            EstablishmentTypeGroupName = "Academies",
                            EstablishmentTypeName = "Academy",
                            LaCode = "456",
                            LastSeenInTPSDate = new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 8,
                            StartDate = new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("findteachersforresearch.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EmailPersonal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmailWork")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nino")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("OptedOutOfResearch")
                        .HasColumnType("boolean");

                    b.Property<string>("ReferenceNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1990, 6, 23, 0, 0, 0, 0, DateTimeKind.Utc),
                            EmailPersonal = "myles@gmail.com",
                            EmailWork = "myles@work.com",
                            FirstName = "Myles",
                            Gender = "Male",
                            LastName = "Rabbit",
                            Nino = "RAB54",
                            OptedOutOfResearch = false,
                            ReferenceNumber = "1234567"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1985, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            EmailPersonal = "jane@gmail.com",
                            EmailWork = "jane@work.com",
                            FirstName = "Jane",
                            Gender = "Female",
                            LastName = "Smith",
                            Nino = "SMI89",
                            OptedOutOfResearch = false,
                            ReferenceNumber = "7654321"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1975, 9, 21, 0, 0, 0, 0, DateTimeKind.Utc),
                            EmailPersonal = "doris@gmail.com",
                            EmailWork = "doris@work.com",
                            FirstName = "Doris",
                            Gender = "Female",
                            LastName = "Madeline",
                            Nino = "DMI869",
                            OptedOutOfResearch = true,
                            ReferenceNumber = "7678890"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1989, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc),
                            EmailPersonal = "ronnie@gmail.com",
                            EmailWork = "ronnie@work.com",
                            FirstName = "Ronnie",
                            Gender = "Male",
                            LastName = "Hotdogs",
                            Nino = "RON345",
                            OptedOutOfResearch = false,
                            ReferenceNumber = "99888776"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            EmailPersonal = "john.doe@gmail.com",
                            EmailWork = "john.doe@work.com",
                            FirstName = "John",
                            Gender = "Male",
                            LastName = "Doe",
                            Nino = "DOE123",
                            OptedOutOfResearch = false,
                            ReferenceNumber = "1111111"
                        },
                        new
                        {
                            Id = 6,
                            DateOfBirth = new DateTime(1992, 2, 14, 0, 0, 0, 0, DateTimeKind.Utc),
                            EmailPersonal = "emily.clark@gmail.com",
                            EmailWork = "emily.clark@work.com",
                            FirstName = "Emily",
                            Gender = "Female",
                            LastName = "Clark",
                            Nino = "CLA456",
                            OptedOutOfResearch = false,
                            ReferenceNumber = "2222222"
                        },
                        new
                        {
                            Id = 7,
                            DateOfBirth = new DateTime(1978, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            EmailPersonal = "michael.brown@gmail.com",
                            EmailWork = "michael.brown@work.com",
                            FirstName = "Michael",
                            Gender = "Male",
                            LastName = "Brown",
                            Nino = "BRO789",
                            OptedOutOfResearch = false,
                            ReferenceNumber = "3333333"
                        },
                        new
                        {
                            Id = 8,
                            DateOfBirth = new DateTime(1995, 4, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            EmailPersonal = "sarah.johnson@gmail.com",
                            EmailWork = "sarah.johnson@work.com",
                            FirstName = "Sarah",
                            Gender = "Female",
                            LastName = "Johnson",
                            Nino = "JOH012",
                            OptedOutOfResearch = false,
                            ReferenceNumber = "4444444"
                        },
                        new
                        {
                            Id = 9,
                            DateOfBirth = new DateTime(1983, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc),
                            EmailPersonal = "david.wilson@gmail.com",
                            EmailWork = "david.wilson@work.com",
                            FirstName = "David",
                            Gender = "Male",
                            LastName = "Wilson",
                            Nino = "WIL345",
                            OptedOutOfResearch = false,
                            ReferenceNumber = "5555555"
                        },
                        new
                        {
                            Id = 10,
                            DateOfBirth = new DateTime(1987, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            EmailPersonal = "laura.martinez@gmail.com",
                            EmailWork = "laura.martinez@work.com",
                            FirstName = "Laura",
                            Gender = "Female",
                            LastName = "Martinez",
                            Nino = "MAR678",
                            OptedOutOfResearch = false,
                            ReferenceNumber = "6666666"
                        },
                        new
                        {
                            Id = 11,
                            DateOfBirth = new DateTime(1991, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            EmailPersonal = "james.anderson@gmail.com",
                            EmailWork = "james.anderson@work.com",
                            FirstName = "James",
                            Gender = "Male",
                            LastName = "Anderson",
                            Nino = "AND901",
                            OptedOutOfResearch = false,
                            ReferenceNumber = "7777777"
                        },
                        new
                        {
                            Id = 12,
                            DateOfBirth = new DateTime(1993, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc),
                            EmailPersonal = "sophia.lewis@gmail.com",
                            EmailWork = "sophia.lewis@work.com",
                            FirstName = "Sophia",
                            Gender = "Female",
                            LastName = "Lewis",
                            Nino = "LEW234",
                            OptedOutOfResearch = false,
                            ReferenceNumber = "8888888"
                        },
                        new
                        {
                            Id = 13,
                            DateOfBirth = new DateTime(1988, 9, 2, 0, 0, 0, 0, DateTimeKind.Utc),
                            EmailPersonal = "robert.walker@gmail.com",
                            EmailWork = "robert.walker@work.com",
                            FirstName = "Robert",
                            Gender = "Male",
                            LastName = "Walker",
                            Nino = "WAL567",
                            OptedOutOfResearch = false,
                            ReferenceNumber = "9999999"
                        },
                        new
                        {
                            Id = 14,
                            DateOfBirth = new DateTime(1986, 10, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            EmailPersonal = "olivia.harris@gmail.com",
                            EmailWork = "olivia.harris@work.com",
                            FirstName = "Olivia",
                            Gender = "Female",
                            LastName = "Harris",
                            Nino = "HAR890",
                            OptedOutOfResearch = false,
                            ReferenceNumber = "1010101"
                        });
                });

            modelBuilder.Entity("findteachersforresearch.Models.ProfStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ITTCourse")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ITTStartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<int>("StatusName")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("ProfStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PersonId = 1,
                            StatusName = 0
                        },
                        new
                        {
                            Id = 2,
                            PersonId = 2,
                            StatusName = 1
                        },
                        new
                        {
                            Id = 3,
                            ITTCourse = "Applied Physics",
                            ITTStartDate = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 3,
                            StatusName = 2
                        },
                        new
                        {
                            Id = 4,
                            ITTCourse = "Geography",
                            ITTStartDate = new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 4,
                            StatusName = 0
                        },
                        new
                        {
                            Id = 5,
                            ITTCourse = "Art",
                            ITTStartDate = new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 5,
                            StatusName = 2
                        },
                        new
                        {
                            Id = 6,
                            ITTCourse = "French",
                            ITTStartDate = new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 6,
                            StatusName = 2
                        },
                        new
                        {
                            Id = 7,
                            ITTCourse = "Biology",
                            ITTStartDate = new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 7,
                            StatusName = 2
                        },
                        new
                        {
                            Id = 8,
                            ITTCourse = "Maths",
                            ITTStartDate = new DateTime(2011, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 8,
                            StatusName = 0
                        },
                        new
                        {
                            Id = 9,
                            ITTCourse = "English",
                            ITTStartDate = new DateTime(2008, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 9,
                            StatusName = 0
                        },
                        new
                        {
                            Id = 10,
                            ITTCourse = "Woodwork",
                            ITTStartDate = new DateTime(2009, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 10,
                            StatusName = 0
                        },
                        new
                        {
                            Id = 11,
                            ITTCourse = "Metal Work",
                            ITTStartDate = new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 11,
                            StatusName = 0
                        },
                        new
                        {
                            Id = 12,
                            ITTCourse = "Latin",
                            ITTStartDate = new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 12,
                            StatusName = 0
                        },
                        new
                        {
                            Id = 13,
                            ITTCourse = "Spanish",
                            ITTStartDate = new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 13,
                            StatusName = 0
                        },
                        new
                        {
                            Id = 14,
                            ITTCourse = "Religion",
                            ITTStartDate = new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 14,
                            StatusName = 0
                        });
                });

            modelBuilder.Entity("findteachersforresearch.Models.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AwardDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Name")
                        .HasColumnType("integer");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Qualification");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AwardDate = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = 0,
                            PersonId = 1
                        },
                        new
                        {
                            Id = 2,
                            AwardDate = new DateTime(2017, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = 2,
                            PersonId = 2
                        },
                        new
                        {
                            Id = 4,
                            AwardDate = new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = 0,
                            PersonId = 4
                        },
                        new
                        {
                            Id = 5,
                            AwardDate = new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = 0,
                            PersonId = 8
                        },
                        new
                        {
                            Id = 6,
                            AwardDate = new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = 0,
                            PersonId = 9
                        },
                        new
                        {
                            Id = 7,
                            AwardDate = new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = 0,
                            PersonId = 10
                        },
                        new
                        {
                            Id = 8,
                            AwardDate = new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = 0,
                            PersonId = 11
                        },
                        new
                        {
                            Id = 9,
                            AwardDate = new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = 2,
                            PersonId = 11
                        },
                        new
                        {
                            Id = 10,
                            AwardDate = new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = 2,
                            PersonId = 12
                        },
                        new
                        {
                            Id = 11,
                            AwardDate = new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = 2,
                            PersonId = 13
                        },
                        new
                        {
                            Id = 12,
                            AwardDate = new DateTime(2009, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = 2,
                            PersonId = 14
                        });
                });

            modelBuilder.Entity("findteachersforresearch.Models.ResearchRound", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("ResearchRounds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "will@education.gov.uk",
                            CreatedDate = new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Research to test if Feature X was a good one for newly qualified teachers.",
                            Name = "Teacher Vacancies New Feature X",
                            Note = "This is a note to say this research round is going to be great",
                            PersonId = 1,
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "steph@education.gov.uk",
                            CreatedDate = new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Research to test if Feature Y was a good one for qualified teachers with an NPQ.",
                            Name = "Teacher Vacancies New Feature Y",
                            Note = "This is a note to say this research round is going to be cold",
                            PersonId = 2,
                            Type = 0
                        });
                });

            modelBuilder.Entity("findteachersforresearch.Models.Employment", b =>
                {
                    b.HasOne("findteachersforresearch.Models.Person", null)
                        .WithMany("Employments")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("findteachersforresearch.Models.ProfStatus", b =>
                {
                    b.HasOne("findteachersforresearch.Models.Person", null)
                        .WithMany("ProfStatuses")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("findteachersforresearch.Models.Qualification", b =>
                {
                    b.HasOne("findteachersforresearch.Models.Person", null)
                        .WithMany("Qualifications")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("findteachersforresearch.Models.ResearchRound", b =>
                {
                    b.HasOne("findteachersforresearch.Models.Person", null)
                        .WithMany("ResearchRounds")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("findteachersforresearch.Models.Person", b =>
                {
                    b.Navigation("Employments");

                    b.Navigation("ProfStatuses");

                    b.Navigation("Qualifications");

                    b.Navigation("ResearchRounds");
                });
#pragma warning restore 612, 618
        }
    }
}
