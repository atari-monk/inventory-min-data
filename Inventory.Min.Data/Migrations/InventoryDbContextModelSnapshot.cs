﻿// <auto-generated />
using System;
using Inventory.Min.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inventory.Min.Data.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    partial class InventoryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Inventory.Min.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(280)
                        .HasColumnType("nvarchar(280)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8276),
                            Name = "Food",
                            UpdatedDate = new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8306)
                        });
                });

            modelBuilder.Entity("Inventory.Min.Data.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(280)
                        .HasColumnType("nvarchar(280)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Currency");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8338),
                            Name = "PLN",
                            UpdatedDate = new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8340)
                        });
                });

            modelBuilder.Entity("Inventory.Min.Data.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<double?>("Depth")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasMaxLength(280)
                        .HasColumnType("nvarchar(280)");

                    b.Property<double?>("Diameter")
                        .HasColumnType("float");

                    b.Property<double?>("Heigth")
                        .HasColumnType("float");

                    b.Property<string>("ImagePath")
                        .HasMaxLength(260)
                        .HasColumnType("nvarchar(260)");

                    b.Property<double?>("Length")
                        .HasColumnType("float");

                    b.Property<int?>("LengthUnitId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<DateTime?>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("PurchasePrice")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal?>("SellPrice")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.Property<int?>("TagId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Volume")
                        .HasColumnType("float");

                    b.Property<int?>("VolumeUnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("LengthUnitId");

                    b.HasIndex("StateId");

                    b.HasIndex("TagId");

                    b.HasIndex("VolumeUnitId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Inventory.Min.Data.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(280)
                        .HasColumnType("nvarchar(280)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("State");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8397),
                            Name = "Fresh",
                            UpdatedDate = new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8399)
                        });
                });

            modelBuilder.Entity("Inventory.Min.Data.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(280)
                        .HasColumnType("nvarchar(280)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tag");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8417),
                            Name = "Preserves",
                            UpdatedDate = new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8418)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8420),
                            Name = "Shopping 08.2022",
                            UpdatedDate = new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8422)
                        });
                });

            modelBuilder.Entity("Inventory.Min.Data.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(280)
                        .HasColumnType("nvarchar(280)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Unit");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8439),
                            Description = "Centimetre",
                            Name = "cm",
                            UpdatedDate = new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8441)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8445),
                            Description = "Litre",
                            Name = "l",
                            UpdatedDate = new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8447)
                        });
                });

            modelBuilder.Entity("Inventory.Min.Data.Category", b =>
                {
                    b.HasOne("Inventory.Min.Data.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Inventory.Min.Data.Item", b =>
                {
                    b.HasOne("Inventory.Min.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Inventory.Min.Data.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId");

                    b.HasOne("Inventory.Min.Data.Unit", "LengthUnit")
                        .WithMany()
                        .HasForeignKey("LengthUnitId");

                    b.HasOne("Inventory.Min.Data.Unit", "State")
                        .WithMany()
                        .HasForeignKey("StateId");

                    b.HasOne("Inventory.Min.Data.Unit", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId");

                    b.HasOne("Inventory.Min.Data.Unit", "VolumeUnit")
                        .WithMany()
                        .HasForeignKey("VolumeUnitId");

                    b.Navigation("Category");

                    b.Navigation("Currency");

                    b.Navigation("LengthUnit");

                    b.Navigation("State");

                    b.Navigation("Tag");

                    b.Navigation("VolumeUnit");
                });

            modelBuilder.Entity("Inventory.Min.Data.Category", b =>
                {
                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
