using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class CreateProductOrders2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_Order_OrderId",
                table: "ProductOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

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

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_Orders_OrderId",
                table: "ProductOrder",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_Orders_OrderId",
                table: "ProductOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

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

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_Order_OrderId",
                table: "ProductOrder",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
