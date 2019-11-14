using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class ChangeAgeFromStringToIntCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("a4cf0dbf-ef9c-4d59-8720-60d7d2ba3df8"), null, new DateTime(2019, 11, 14, 6, 59, 0, 205, DateTimeKind.Utc).AddTicks(490), "StrawberryTea", 50000.0, 150, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("4416e80b-33a4-42ae-8159-0094450a890b"), null, new DateTime(2019, 11, 14, 6, 59, 0, 207, DateTimeKind.Utc).AddTicks(8525), "PeachTea", 45000.0, 100, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("0fb4b4c9-ee62-4947-b054-3c6d1a06e6b2"), null, new DateTime(2019, 11, 14, 6, 59, 0, 207, DateTimeKind.Utc).AddTicks(8769), "LycheeTea", 55000.0, 75, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("0fb4b4c9-ee62-4947-b054-3c6d1a06e6b2"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("4416e80b-33a4-42ae-8159-0094450a890b"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("a4cf0dbf-ef9c-4d59-8720-60d7d2ba3df8"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

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
    }
}
