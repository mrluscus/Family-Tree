﻿// <auto-generated />
using System;
using FamilyTree.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FamilyTree.Data.Migrations
{
    [DbContext(typeof(FamilyTreeDbContext))]
    [Migration("20190529101236_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("FamilyTree.Data.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("FamilyTree.Data.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Biography");

                    b.Property<DateTime?>("BirthDate");

                    b.Property<DateTime?>("DeathDate");

                    b.Property<string>("FirstName");

                    b.Property<int>("GenderId");

                    b.Property<string>("LastName");

                    b.Property<string>("PatronymicName");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("FamilyTree.Data.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Path")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("FamilyTree.Data.Models.PhotoPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PersonId");

                    b.Property<int>("PhotoId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("PhotoId");

                    b.ToTable("PhotoPerson");
                });

            modelBuilder.Entity("FamilyTree.Data.Models.Relative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Person1Id");

                    b.Property<int>("Person2Id");

                    b.Property<int>("RelativeTypeId");

                    b.HasKey("Id");

                    b.HasIndex("Person1Id");

                    b.HasIndex("Person2Id");

                    b.HasIndex("RelativeTypeId");

                    b.ToTable("Relative");
                });

            modelBuilder.Entity("FamilyTree.Data.Models.RelativeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("RelativeType");
                });

            modelBuilder.Entity("FamilyTree.Data.Models.Person", b =>
                {
                    b.HasOne("FamilyTree.Data.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FamilyTree.Data.Models.PhotoPerson", b =>
                {
                    b.HasOne("FamilyTree.Data.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FamilyTree.Data.Models.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FamilyTree.Data.Models.Relative", b =>
                {
                    b.HasOne("FamilyTree.Data.Models.Person", "Person1")
                        .WithMany()
                        .HasForeignKey("Person1Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FamilyTree.Data.Models.Person", "Person2")
                        .WithMany()
                        .HasForeignKey("Person2Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FamilyTree.Data.Models.RelativeType", "RelativeType")
                        .WithMany()
                        .HasForeignKey("RelativeTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
