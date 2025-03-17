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
    [Migration("20250205155459_newpersonfields")]
    partial class newpersonfields
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
                            Id = 1,
                            EmploymentType = "Part Time Regular",
                            EstablishmentCode = "1234",
                            EstablishmentCounty = "Derbyshire",
                            EstablishmentName = "Gladys Buxton School",
                            EstablishmentSource = "GIAS",
                            EstablishmentStatus = "Open",
                            EstablishmentTown = "Dronfield",
                            EstablishmentTypeGroupName = "Local Authority MAintained Schools",
                            EstablishmentTypeName = "Foundation School",
                            LaCode = "925",
                            LastSeenInTPSDate = new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            PersonId = 1,
                            StartDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2,
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

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nino")
                        .IsRequired()
                        .HasColumnType("text");

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
                            LastName = "Rabbit",
                            Nino = "RAB54",
                            ReferenceNumber = "1234567"
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

            modelBuilder.Entity("findteachersforresearch.Models.Person", b =>
                {
                    b.Navigation("Employments");
                });
#pragma warning restore 612, 618
        }
    }
}
