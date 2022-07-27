using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Min.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(280)", maxLength: 280, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Category_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Category",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(280)", maxLength: 280, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(280)", maxLength: 280, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(280)", maxLength: 280, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(280)", maxLength: 280, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(280)", maxLength: 280, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    PurchasePrice = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    SellPrice = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    LengthUnitId = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<double>(type: "float", nullable: true),
                    Heigth = table.Column<double>(type: "float", nullable: true),
                    Depth = table.Column<double>(type: "float", nullable: true),
                    Diameter = table.Column<double>(type: "float", nullable: true),
                    VolumeUnitId = table.Column<int>(type: "int", nullable: true),
                    Volume = table.Column<double>(type: "float", nullable: true),
                    TagId = table.Column<int>(type: "int", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Unit_LengthUnitId",
                        column: x => x.LengthUnitId,
                        principalTable: "Unit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Unit_StateId",
                        column: x => x.StateId,
                        principalTable: "Unit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Unit_TagId",
                        column: x => x.TagId,
                        principalTable: "Unit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Item_Unit_VolumeUnitId",
                        column: x => x.VolumeUnitId,
                        principalTable: "Unit",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "ParentId", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2459), null, "Food", null, new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2520), null, "PLN", new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2537), "Sold", "Very good", new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2551), null, "Preserves", new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.InsertData(
                table: "Unit",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2565), "Centimetre", "cm", new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2566) },
                    { 2, new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2568), "Litre", "l", new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2570) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentId",
                table: "Category",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_CategoryId",
                table: "Item",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_CurrencyId",
                table: "Item",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_LengthUnitId",
                table: "Item",
                column: "LengthUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_StateId",
                table: "Item",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_TagId",
                table: "Item",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_VolumeUnitId",
                table: "Item",
                column: "VolumeUnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "Unit");
        }
    }
}
