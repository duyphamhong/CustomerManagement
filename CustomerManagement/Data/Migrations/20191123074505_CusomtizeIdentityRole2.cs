using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class CusomtizeIdentityRole2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IPAddress",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("2dee6a0f-0224-45b2-bd61-613b5cb2b055"), null, new DateTime(2019, 11, 23, 7, 45, 4, 728, DateTimeKind.Utc).AddTicks(3472), "StrawberryTea", 50000.0, 150, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("2041dc76-58a1-4b0e-b730-750e0475d758"), null, new DateTime(2019, 11, 23, 7, 45, 4, 730, DateTimeKind.Utc).AddTicks(6516), "PeachTea", 45000.0, 100, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("5ffbffd6-59de-4508-86eb-b920115c4478"), null, new DateTime(2019, 11, 23, 7, 45, 4, 730, DateTimeKind.Utc).AddTicks(6719), "LycheeTea", 55000.0, 75, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("2041dc76-58a1-4b0e-b730-750e0475d758"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("2dee6a0f-0224-45b2-bd61-613b5cb2b055"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("5ffbffd6-59de-4508-86eb-b920115c4478"));

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "IPAddress",
                table: "AspNetRoles");

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
    }
}
