using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class AddMockDataForTeas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qauntity",
                table: "Teas");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Teas",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Teas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("766dc840-d2eb-4c07-a775-d2f78126012f"), null, new DateTime(2019, 11, 13, 17, 57, 14, 498, DateTimeKind.Utc).AddTicks(3599), "StrawberryTea", 50000.0, 150, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("b5a7aea2-5296-40ab-bcc0-8b777363f9aa"), null, new DateTime(2019, 11, 13, 17, 57, 14, 499, DateTimeKind.Utc).AddTicks(7970), "PeachTea", 45000.0, 100, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("1ef0b997-4a94-4328-9fc7-a8c37efa5641"), null, new DateTime(2019, 11, 13, 17, 57, 14, 499, DateTimeKind.Utc).AddTicks(8135), "LycheeTea", 55000.0, 75, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("1ef0b997-4a94-4328-9fc7-a8c37efa5641"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("766dc840-d2eb-4c07-a775-d2f78126012f"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("b5a7aea2-5296-40ab-bcc0-8b777363f9aa"));

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Teas");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Teas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<string>(
                name: "Qauntity",
                table: "Teas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
