using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class CreateCategoryMockData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("4b80a7ae-f8f0-4ecf-8c25-acde5ce0c960"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("7af876e2-4071-4054-ba9d-b7b3efd3fbdd"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("7d0f422e-b9b9-4c28-917f-52edcf8c4897"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("e427418b-d05d-4136-9c60-bf45ab7e9bf0"), null, new DateTime(2019, 12, 29, 10, 28, 51, 925, DateTimeKind.Local).AddTicks(5913), "Car", null, null },
                    { new Guid("f99d255c-1d9d-4151-ad20-3865ad03412c"), null, new DateTime(2019, 12, 29, 10, 28, 51, 927, DateTimeKind.Local).AddTicks(3256), "Bycicle", null, null },
                    { new Guid("3ac643d8-6704-4fab-88f4-fc96ed82e502"), null, new DateTime(2019, 12, 29, 10, 28, 51, 927, DateTimeKind.Local).AddTicks(3376), "Motor", null, null }
                });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("f82df266-9fb3-44fe-93d7-509933b53c6a"), null, new DateTime(2019, 12, 29, 10, 28, 51, 927, DateTimeKind.Local).AddTicks(3960), "StrawberryTea", 50000.0, 150, null, null },
                    { new Guid("3a4f1dad-4ed1-48a7-b8a5-a30563ff8db4"), null, new DateTime(2019, 12, 29, 10, 28, 51, 927, DateTimeKind.Local).AddTicks(5446), "PeachTea", 45000.0, 100, null, null },
                    { new Guid("306a21aa-deb2-407c-b6f2-bbff9d7394c7"), null, new DateTime(2019, 12, 29, 10, 28, 51, 927, DateTimeKind.Local).AddTicks(5499), "LycheeTea", 55000.0, 75, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ac643d8-6704-4fab-88f4-fc96ed82e502"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e427418b-d05d-4136-9c60-bf45ab7e9bf0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f99d255c-1d9d-4151-ad20-3865ad03412c"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("306a21aa-deb2-407c-b6f2-bbff9d7394c7"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("3a4f1dad-4ed1-48a7-b8a5-a30563ff8db4"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("f82df266-9fb3-44fe-93d7-509933b53c6a"));

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("7d0f422e-b9b9-4c28-917f-52edcf8c4897"), null, new DateTime(2019, 12, 29, 9, 36, 6, 657, DateTimeKind.Local).AddTicks(786), "StrawberryTea", 50000.0, 150, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("7af876e2-4071-4054-ba9d-b7b3efd3fbdd"), null, new DateTime(2019, 12, 29, 9, 36, 6, 667, DateTimeKind.Local).AddTicks(2396), "PeachTea", 45000.0, 100, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("4b80a7ae-f8f0-4ecf-8c25-acde5ce0c960"), null, new DateTime(2019, 12, 29, 9, 36, 6, 667, DateTimeKind.Local).AddTicks(3395), "LycheeTea", 55000.0, 75, null, null });
        }
    }
}
