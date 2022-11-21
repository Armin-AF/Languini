﻿// <auto-generated />
using System;
using LanguageFika.Api.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LanguageFika.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LanguageFika.Api.Models.Meeting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Language")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Meetings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("299e8f29-e1f1-4cfd-8475-1e44493a0c0d"),
                            Date = new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 1",
                            Language = 17,
                            Location = "Test location 1"
                        },
                        new
                        {
                            Id = new Guid("6f34521b-5786-4c2a-a90a-a12ae87e03d7"),
                            Date = new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 2",
                            Language = 9,
                            Location = "Test location 2"
                        },
                        new
                        {
                            Id = new Guid("566d4a6f-1909-4cd3-81d4-8f6579db94a0"),
                            Date = new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 3",
                            Language = 8,
                            Location = "Test location 3"
                        },
                        new
                        {
                            Id = new Guid("be4aa1c3-afb9-44a8-99d5-6686b8233038"),
                            Date = new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 4",
                            Language = 6,
                            Location = "Test location 4"
                        },
                        new
                        {
                            Id = new Guid("19889ed0-30ac-4e34-aad1-254ba56239b1"),
                            Date = new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 5",
                            Language = 1,
                            Location = "Test location 5"
                        },
                        new
                        {
                            Id = new Guid("4ba87d23-c957-473f-8670-6f55d23d419a"),
                            Date = new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 6",
                            Language = 0,
                            Location = "Test location 6"
                        },
                        new
                        {
                            Id = new Guid("38e804c6-6785-45cb-8cc2-e518238cf431"),
                            Date = new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 7",
                            Language = 3,
                            Location = "Test location 7"
                        },
                        new
                        {
                            Id = new Guid("5937bafd-9973-49c3-9273-686b7a749b1b"),
                            Date = new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 8",
                            Language = 4,
                            Location = "Test location 8"
                        },
                        new
                        {
                            Id = new Guid("04448b09-9262-4704-a781-324378853849"),
                            Date = new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 9",
                            Language = 1,
                            Location = "Test location 9"
                        },
                        new
                        {
                            Id = new Guid("f72ccafa-addb-4619-af98-d822d0a13cfa"),
                            Date = new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is a test meeting 10",
                            Language = 20,
                            Location = "Test location 10"
                        });
                });

            modelBuilder.Entity("LanguageFika.Api.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanguageToLearn")
                        .HasColumnType("int");

                    b.Property<int>("LanguageToTeach")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}