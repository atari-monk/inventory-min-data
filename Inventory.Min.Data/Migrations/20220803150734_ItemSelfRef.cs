using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Min.Data.Migrations
{
    public partial class ItemSelfRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Item",
                type: "int",
                nullable: true);

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9425), new DateTime(2022, 8, 3, 17, 7, 34, 349, DateTimeKind.Local).AddTicks(9428) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Item_ParentId",
                table: "Item",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_ParentId",
                table: "Item",
                column: "ParentId",
                principalTable: "Item",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_ParentId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_ParentId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Item");

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
    }
}
