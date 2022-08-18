using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Min.Data.Migrations
{
    public partial class AddLexicon3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(519), null, "EUR", new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(520) },
                    { 3, new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(522), null, "USD", new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(524) }
                });

            migrationBuilder.UpdateData(
                table: "State",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(541), "In storage", new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(545), null, "In use", new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(546) },
                    { 3, new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(548), null, "Depleted", new DateTime(2022, 8, 18, 17, 26, 32, 152, DateTimeKind.Local).AddTicks(550) }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(5931), new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(5933) });

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
                columns: new[] { "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(5991), "Resource depleted", new DateTime(2022, 8, 4, 17, 27, 40, 191, DateTimeKind.Local).AddTicks(5993) });

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
    }
}
