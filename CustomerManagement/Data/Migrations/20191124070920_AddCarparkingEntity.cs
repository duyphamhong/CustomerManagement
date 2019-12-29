using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class AddCarparkingEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    CarIdentity = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Residents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    CarId = table.Column<Guid>(nullable: false),
                    ResidentId = table.Column<Guid>(nullable: false),
                    ParkingStartTime = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    IsMonthlyPaid = table.Column<bool>(nullable: false),
                    PaidUntilMonth = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CarId",
                table: "Tickets",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ResidentId",
                table: "Tickets",
                column: "ResidentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Residents");

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
    }
}
