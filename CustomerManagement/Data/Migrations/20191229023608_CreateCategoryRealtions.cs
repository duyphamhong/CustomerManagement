using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class CreateCategoryRealtions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeaOrders_Customers_CustomerId",
                table: "TeaOrders");

            migrationBuilder.DropIndex(
                name: "IX_TeaOrders_CustomerId",
                table: "TeaOrders");

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

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "TeaOrders");

            migrationBuilder.AddColumn<Guid>(
                name: "AID",
                table: "TeaOrders",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TeaOrders_AID",
                table: "TeaOrders",
                column: "AID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeaOrders_Customers_AID",
                table: "TeaOrders",
                column: "AID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_TeaOrders_Customers_AID",
                table: "TeaOrders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_TeaOrders_AID",
                table: "TeaOrders");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

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

            migrationBuilder.DropColumn(
                name: "AID",
                table: "TeaOrders");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "TeaOrders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_TeaOrders_CustomerId",
                table: "TeaOrders",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeaOrders_Customers_CustomerId",
                table: "TeaOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
