using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Min.Data.Migrations
{
    public partial class AddLexicon2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(5894), new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(5927), new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "ParentId", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(5931), null, "Pasta", 1, new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(5971), new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(5991), new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(6005), new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(6009), new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(6024), new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(6028), new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(6031), new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(6035), new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(6037) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(4988), new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5029), new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5031) });

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5093), new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5095) });

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

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5344), new DateTime(2022, 8, 4, 16, 58, 56, 433, DateTimeKind.Local).AddTicks(5345) });
        }
    }
}
