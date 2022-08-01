using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Min.Data.Migrations
{
    public partial class AddQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8276), new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8338), new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8397), new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8417), new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8420), new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8439), new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8445), new DateTime(2022, 8, 1, 13, 30, 35, 205, DateTimeKind.Local).AddTicks(8447) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Item");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1523), new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1592), new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1617), new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1634), new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1638), new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1698), new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1703), new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1704) });
        }
    }
}
