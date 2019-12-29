using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class CreateProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("0ebbf7ff-3745-41f4-8581-27b67239bd81"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("48661a04-177b-43c1-aa1e-c0f09905eeba"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("a5b28fac-29ac-4a88-aa87-3480a0a8f632"));

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("55238903-d5f7-4d8f-aefc-d73898fc5b76"), null, new DateTime(2019, 12, 22, 16, 3, 41, 599, DateTimeKind.Local).AddTicks(5624), "StrawberryTea", 50000.0, 150, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("2e66f5dd-e3cc-4491-8689-ae8b650eb82d"), null, new DateTime(2019, 12, 22, 16, 3, 41, 601, DateTimeKind.Local).AddTicks(3339), "PeachTea", 45000.0, 100, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("9aa65568-9af3-49fb-a04a-f461444fbf54"), null, new DateTime(2019, 12, 22, 16, 3, 41, 601, DateTimeKind.Local).AddTicks(3479), "LycheeTea", 55000.0, 75, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("2e66f5dd-e3cc-4491-8689-ae8b650eb82d"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("55238903-d5f7-4d8f-aefc-d73898fc5b76"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("9aa65568-9af3-49fb-a04a-f461444fbf54"));

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("48661a04-177b-43c1-aa1e-c0f09905eeba"), null, new DateTime(2019, 11, 24, 7, 9, 20, 446, DateTimeKind.Utc).AddTicks(1326), "StrawberryTea", 50000.0, 150, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("0ebbf7ff-3745-41f4-8581-27b67239bd81"), null, new DateTime(2019, 11, 24, 7, 9, 20, 448, DateTimeKind.Utc).AddTicks(2204), "PeachTea", 45000.0, 100, null, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("a5b28fac-29ac-4a88-aa87-3480a0a8f632"), null, new DateTime(2019, 11, 24, 7, 9, 20, 448, DateTimeKind.Utc).AddTicks(2361), "LycheeTea", 55000.0, 75, null, null });
        }
    }
}
