using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class CreateProductOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    NumberOfOrder = table.Column<int>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrder",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrder", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductOrder_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrder_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("e083f00e-58ba-4298-89ba-85ba056ec46c"), null, new DateTime(2019, 12, 29, 13, 52, 32, 795, DateTimeKind.Local).AddTicks(6700), "Car", null, null },
                    { new Guid("8eeaf317-ac9e-46cb-96ad-b86335668f8b"), null, new DateTime(2019, 12, 29, 13, 52, 32, 797, DateTimeKind.Local).AddTicks(3593), "Bycicle", null, null },
                    { new Guid("ddfa69d5-1ff1-4c97-9d9b-2f9cc1c85210"), null, new DateTime(2019, 12, 29, 13, 52, 32, 797, DateTimeKind.Local).AddTicks(3717), "Motor", null, null }
                });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "Price", "Quantity", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2492e2a5-5e77-478a-b66e-1a2a3c8e7dc9"), null, new DateTime(2019, 12, 29, 13, 52, 32, 798, DateTimeKind.Local).AddTicks(1031), "StrawberryTea", 50000.0, 150, null, null },
                    { new Guid("337a7834-368d-4a03-982e-bce623cb3d15"), null, new DateTime(2019, 12, 29, 13, 52, 32, 798, DateTimeKind.Local).AddTicks(2556), "PeachTea", 45000.0, 100, null, null },
                    { new Guid("d410e683-7a5f-4436-aa89-3915bb1c2c08"), null, new DateTime(2019, 12, 29, 13, 52, 32, 798, DateTimeKind.Local).AddTicks(2610), "LycheeTea", 55000.0, 75, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrder_ProductId",
                table: "ProductOrder",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductOrder");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8eeaf317-ac9e-46cb-96ad-b86335668f8b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ddfa69d5-1ff1-4c97-9d9b-2f9cc1c85210"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e083f00e-58ba-4298-89ba-85ba056ec46c"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("2492e2a5-5e77-478a-b66e-1a2a3c8e7dc9"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("337a7834-368d-4a03-982e-bce623cb3d15"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("d410e683-7a5f-4436-aa89-3915bb1c2c08"));

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
    }
}
