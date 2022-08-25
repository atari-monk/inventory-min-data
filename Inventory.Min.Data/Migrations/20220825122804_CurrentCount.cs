using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Min.Data.Migrations
{
    public partial class CurrentCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Item",
                newName: "InitialCount");

            migrationBuilder.AddColumn<int>(
                name: "CurrentCount",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4492), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4529), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4533), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4565), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4569), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4573), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4587), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4591), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4594), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4610), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4614), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4634), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4638), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4642), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4645), new DateTime(2022, 8, 25, 14, 28, 4, 426, DateTimeKind.Local).AddTicks(4647) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentCount",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "InitialCount",
                table: "Item",
                newName: "Quantity");

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
        }
    }
}
