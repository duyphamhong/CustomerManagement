using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class CreateTeaOrderTeaManyToManyRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeaOrderTeas",
                columns: table => new
                {
                    TeaOrderId = table.Column<Guid>(nullable: false),
                    TeaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeaOrderTeas", x => new { x.TeaOrderId, x.TeaId });
                    table.ForeignKey(
                        name: "FK_TeaOrderTeas_Teas_TeaId",
                        column: x => x.TeaId,
                        principalTable: "Teas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeaOrderTeas_TeaOrders_TeaOrderId",
                        column: x => x.TeaOrderId,
                        principalTable: "TeaOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeaOrderTeas_TeaId",
                table: "TeaOrderTeas",
                column: "TeaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeaOrderTeas");
        }
    }
}
