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
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2776),
                            Name = "Food",
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2807)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2812),
                            Name = "Furniture",
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2813)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2816),
                            Name = "Pasta",
                            ParentId = 1,
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2818)
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
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2853),
                            Name = "PLN",
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2855)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2858),
                            Name = "EUR",
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2859)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2861),
                            Name = "USD",
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2863)
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

                    b.Property<double?>("Mass")
                        .HasColumnType("float");

                    b.Property<int?>("MassUnitId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

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

                    b.HasIndex("ParentId");

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
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2881),
                            Name = "In storage",
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2883)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2886),
                            Name = "In use",
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2887)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2889),
                            Name = "Depleted",
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2891)
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
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2906),
                            Name = "Preserves",
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2908)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2910),
                            Name = "Shopping 08.2022",
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2912)
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
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2929),
                            Description = "Centimetre",
                            Name = "cm",
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2931)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2934),
                            Description = "Litre",
                            Name = "l",
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2935)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2937),
                            Description = "Gram",
                            Name = "g",
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2939)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2941),
                            Description = "Kilogram",
                            Name = "kg",
                            UpdatedDate = new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2943)
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

                    b.HasOne("Inventory.Min.Data.Item", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.HasOne("Inventory.Min.Data.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");

                    b.HasOne("Inventory.Min.Data.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId");

                    b.HasOne("Inventory.Min.Data.Unit", "VolumeUnit")
                        .WithMany()
                        .HasForeignKey("VolumeUnitId");

                    b.Navigation("Category");

                    b.Navigation("Currency");

                    b.Navigation("LengthUnit");

                    b.Navigation("Parent");

                    b.Navigation("State");

                    b.Navigation("Tag");

                    b.Navigation("VolumeUnit");
                });

            modelBuilder.Entity("Inventory.Min.Data.Category", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("Inventory.Min.Data.Item", b =>
                {
                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
