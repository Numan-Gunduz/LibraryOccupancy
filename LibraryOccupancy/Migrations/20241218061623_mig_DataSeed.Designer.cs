﻿// <auto-generated />
using LibraryOccupancy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryOccupancy.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20241218061623_mig_DataSeed")]
    partial class mig_DataSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryOccupancy.Models.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ComputerTableCapacity")
                        .HasColumnType("int");

                    b.Property<int>("ComputerTableOccupied")
                        .HasColumnType("int");

                    b.Property<string>("LibraryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudyTableCapacity")
                        .HasColumnType("int");

                    b.Property<int>("StudyTableOccupied")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Libraries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ComputerTableCapacity = 20,
                            ComputerTableOccupied = 0,
                            LibraryName = "Prof. Dr. Abdulkadir Karahan Kütüphanesi",
                            StudyTableCapacity = 100,
                            StudyTableOccupied = 80
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
