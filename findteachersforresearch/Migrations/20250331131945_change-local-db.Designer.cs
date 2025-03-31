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
    [Migration("20250331131945_change-local-db")]
    partial class changelocaldb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PersonResearchRound", b =>
                {
                    b.Property<int>("PersonsId")
                        .HasColumnType("integer");

                    b.Property<int>("ResearchRoundsId")
                        .HasColumnType("integer");

                    b.HasKey("PersonsId", "ResearchRoundsId");

                    b.HasIndex("ResearchRoundsId");

                    b.ToTable("PersonResearchRound");
                });

            modelBuilder.Entity("findteachersforresearch.Models.Employment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EmployerPostcode")
                        .HasColumnType("text");

                    b.Property<string>("EmploymentType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EstablishmentName")
                        .HasColumnType("text");

                    b.Property<string>("EstablishmentSource")
                        .HasColumnType("text");

                    b.Property<string>("EstablishmentStatus")
                        .HasColumnType("text");

                    b.Property<string>("EstablishmentTypeGroupName")
                        .HasColumnType("text");

                    b.Property<DateTime>("ExtractDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("FSMPercentage")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("LastSeenInTPSDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("NumberOfPupils")
                        .HasColumnType("integer");

                    b.Property<string>("PersonId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhaseOfEducation")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Urn")
                        .HasColumnType("text");

                    b.Property<string>("WithdrawalConfirmed")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Employment");
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

                    b.Property<bool>("OptedOutOfResearch")
                        .HasColumnType("boolean");

                    b.Property<string>("PersonId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReferenceNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("findteachersforresearch.Models.ProfStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("PersonId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StatusName")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("ProfStatus");
                });

            modelBuilder.Entity("findteachersforresearch.Models.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("EYTSDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MQ")
                        .HasColumnType("integer");

                    b.Property<int>("NPQEL")
                        .HasColumnType("integer");

                    b.Property<int>("NPQH")
                        .HasColumnType("integer");

                    b.Property<int>("NPQLBC")
                        .HasColumnType("integer");

                    b.Property<int>("NPQLTD")
                        .HasColumnType("integer");

                    b.Property<int>("NPQML")
                        .HasColumnType("integer");

                    b.Property<int>("NPQSL")
                        .HasColumnType("integer");

                    b.Property<string>("PersonId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("QTSDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("Qualification");
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
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ResearchRounds");
                });

            modelBuilder.Entity("PersonResearchRound", b =>
                {
                    b.HasOne("findteachersforresearch.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("PersonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("findteachersforresearch.Models.ResearchRound", null)
                        .WithMany()
                        .HasForeignKey("ResearchRoundsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("findteachersforresearch.Models.Employment", b =>
                {
                    b.HasOne("findteachersforresearch.Models.Person", null)
                        .WithMany("Employments")
                        .HasForeignKey("PersonId")
                        .HasPrincipalKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("findteachersforresearch.Models.ProfStatus", b =>
                {
                    b.HasOne("findteachersforresearch.Models.Person", "Person")
                        .WithOne("ProfStatus")
                        .HasForeignKey("findteachersforresearch.Models.ProfStatus", "PersonId")
                        .HasPrincipalKey("findteachersforresearch.Models.Person", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("findteachersforresearch.Models.Qualification", b =>
                {
                    b.HasOne("findteachersforresearch.Models.Person", "Person")
                        .WithOne("Qualification")
                        .HasForeignKey("findteachersforresearch.Models.Qualification", "PersonId")
                        .HasPrincipalKey("findteachersforresearch.Models.Person", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("findteachersforresearch.Models.Person", b =>
                {
                    b.Navigation("Employments");

                    b.Navigation("ProfStatus")
                        .IsRequired();

                    b.Navigation("Qualification")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
