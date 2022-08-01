using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Min.Data.Migrations
{
    public partial class AddLexicon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1617), null, "Fresh", new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1634), new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1638), null, "Shopping 08.2022", new DateTime(2022, 8, 1, 13, 9, 5, 45, DateTimeKind.Local).AddTicks(1640) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2459), new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2520), new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2537), "Sold", "Very good", new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2551), new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2565), new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2568), new DateTime(2022, 7, 27, 21, 25, 7, 787, DateTimeKind.Local).AddTicks(2570) });
        }
    }
}
