using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Min.Data.Migrations
{
    public partial class AddMass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Mass",
                table: "Item",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MassUnitId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(4988), new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "ParentId", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5029), null, "Furniture", null, new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5071), new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5093), "Resource depleted", new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5115), new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5118), new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5313), new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5336), new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.InsertData(
                table: "Unit",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5340), "Gram", "g", new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5342) },
                    { 4, new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5344), "Kilogram", "kg", new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5345) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Mass",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "MassUnitId",
                table: "Item");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9336), new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9402), new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9425), "Fresh", new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9450), new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9456), new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9475), new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9480), new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9482) });
        }
    }
}
