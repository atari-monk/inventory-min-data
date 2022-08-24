using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Min.Data.Migrations
{
    public partial class FixItemBug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Unit_StateId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Unit_TagId",
                table: "Item");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2776), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2812), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2816), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2853), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2858), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2861), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2881), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2886), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2889), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2906), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2910), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2929), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2934), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2937), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2941), new DateTime(2022, 8, 24, 17, 27, 12, 543, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_State_StateId",
                table: "Item",
                column: "StateId",
                principalTable: "State",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Tag_TagId",
                table: "Item",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_State_StateId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Tag_TagId",
                table: "Item");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(435), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(477), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(481), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(515), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(519), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(522), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(541), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(545), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(548), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(563), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(566), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(583), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(587), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(590), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(594), new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(596) });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Unit_StateId",
                table: "Item",
                column: "StateId",
                principalTable: "Unit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Unit_TagId",
                table: "Item",
                column: "TagId",
                principalTable: "Unit",
                principalColumn: "Id");
        }
    }
}
