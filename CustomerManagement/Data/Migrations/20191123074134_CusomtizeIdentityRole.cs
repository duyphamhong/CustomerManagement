using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class CusomtizeIdentityRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("5a01bccd-08a1-4a69-8df2-cd6977fc8aec"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("5e224ed8-6c1b-46ee-bda7-30ccb05233bb"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("a5b01fa0-c1ce-4338-bac6-f258a9838f45"));

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("40b78f81-4984-4463-8b75-dc6903fe0bc5"), null, new DateTime(2019, 11, 23, 7, 41, 33, 723, DateTimeKind.Utc).AddTicks(2758), "StrawberryTea", 50000.0, 150, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("1b15e66a-4681-4336-b54f-cecc89cc037c"), null, new DateTime(2019, 11, 23, 7, 41, 33, 725, DateTimeKind.Utc).AddTicks(4148), "PeachTea", 45000.0, 100, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("31cbff75-1b2f-40f6-9946-f2c985e4e858"), null, new DateTime(2019, 11, 23, 7, 41, 33, 725, DateTimeKind.Utc).AddTicks(4350), "LycheeTea", 55000.0, 75, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("1b15e66a-4681-4336-b54f-cecc89cc037c"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("31cbff75-1b2f-40f6-9946-f2c985e4e858"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("40b78f81-4984-4463-8b75-dc6903fe0bc5"));

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("5a01bccd-08a1-4a69-8df2-cd6977fc8aec"), null, new DateTime(2019, 11, 23, 7, 2, 48, 512, DateTimeKind.Utc).AddTicks(6667), "StrawberryTea", 50000.0, 150, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("a5b01fa0-c1ce-4338-bac6-f258a9838f45"), null, new DateTime(2019, 11, 23, 7, 2, 48, 514, DateTimeKind.Utc).AddTicks(1387), "PeachTea", 45000.0, 100, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("5e224ed8-6c1b-46ee-bda7-30ccb05233bb"), null, new DateTime(2019, 11, 23, 7, 2, 48, 514, DateTimeKind.Utc).AddTicks(1545), "LycheeTea", 55000.0, 75, null, null });
        }
    }
}
