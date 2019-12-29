using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class TestUpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08dcee5e-ad73-4fd3-aa44-1e1ebbe641f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51e8b128-6279-43af-8618-c015decf0a9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9cf4a8c8-b16d-4619-9e25-e020f651c18e"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("08cdc182-59d3-4c2d-ac09-707d943e28e2"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("4b05ab8d-b0a1-43f0-b85a-0eadd2de38e2"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("a576add8-2bbe-4b30-bca6-f900822aa5a9"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cars",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("da729730-ddeb-446c-a0dc-370d12ab2315"), null, new DateTime(2019, 12, 29, 14, 14, 23, 365, DateTimeKind.Local).AddTicks(2634), "Car", null, null },
                    { new Guid("4abf397f-063b-4a82-94ef-cdbca7e63267"), null, new DateTime(2019, 12, 29, 14, 14, 23, 367, DateTimeKind.Local).AddTicks(117), "Bycicle", null, null },
                    { new Guid("2f7e17f3-a11b-405a-8df9-1124a9763287"), null, new DateTime(2019, 12, 29, 14, 14, 23, 367, DateTimeKind.Local).AddTicks(314), "Motor", null, null }
                });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("cd815fa5-e66f-46ad-8539-6a7bec03fb12"), null, new DateTime(2019, 12, 29, 14, 14, 23, 367, DateTimeKind.Local).AddTicks(7816), "StrawberryTea", 50000.0, 150, null, null },
                    { new Guid("0afa047f-2c0d-4290-9a41-066ad0b382d5"), null, new DateTime(2019, 12, 29, 14, 14, 23, 367, DateTimeKind.Local).AddTicks(9335), "PeachTea", 45000.0, 100, null, null },
                    { new Guid("f8c0ec45-e5f9-45af-80c0-4f7dd1fd8c4d"), null, new DateTime(2019, 12, 29, 14, 14, 23, 367, DateTimeKind.Local).AddTicks(9388), "LycheeTea", 55000.0, 75, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f7e17f3-a11b-405a-8df9-1124a9763287"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4abf397f-063b-4a82-94ef-cdbca7e63267"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da729730-ddeb-446c-a0dc-370d12ab2315"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("0afa047f-2c0d-4290-9a41-066ad0b382d5"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("cd815fa5-e66f-46ad-8539-6a7bec03fb12"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("f8c0ec45-e5f9-45af-80c0-4f7dd1fd8c4d"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cars");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("51e8b128-6279-43af-8618-c015decf0a9e"), null, new DateTime(2019, 12, 29, 14, 0, 17, 459, DateTimeKind.Local).AddTicks(1949), "Car", null, null },
                    { new Guid("08dcee5e-ad73-4fd3-aa44-1e1ebbe641f1"), null, new DateTime(2019, 12, 29, 14, 0, 17, 461, DateTimeKind.Local).AddTicks(223), "Bycicle", null, null },
                    { new Guid("9cf4a8c8-b16d-4619-9e25-e020f651c18e"), null, new DateTime(2019, 12, 29, 14, 0, 17, 461, DateTimeKind.Local).AddTicks(355), "Motor", null, null }
                });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("a576add8-2bbe-4b30-bca6-f900822aa5a9"), null, new DateTime(2019, 12, 29, 14, 0, 17, 461, DateTimeKind.Local).AddTicks(8649), "StrawberryTea", 50000.0, 150, null, null },
                    { new Guid("08cdc182-59d3-4c2d-ac09-707d943e28e2"), null, new DateTime(2019, 12, 29, 14, 0, 17, 462, DateTimeKind.Local).AddTicks(232), "PeachTea", 45000.0, 100, null, null },
                    { new Guid("4b05ab8d-b0a1-43f0-b85a-0eadd2de38e2"), null, new DateTime(2019, 12, 29, 14, 0, 17, 462, DateTimeKind.Local).AddTicks(287), "LycheeTea", 55000.0, 75, null, null }
                });
        }
    }
}
