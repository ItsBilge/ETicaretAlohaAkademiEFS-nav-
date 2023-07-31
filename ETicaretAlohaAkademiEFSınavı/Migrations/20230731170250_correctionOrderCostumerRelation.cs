using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretAlohaAkademiEFSınavı.Migrations
{
    /// <inheritdoc />
    public partial class correctionOrderCostumerRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderCostumers");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Orders",
                newName: "CostumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CostumerId",
                table: "Orders",
                column: "CostumerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Costumers_CostumerId",
                table: "Orders",
                column: "CostumerId",
                principalTable: "Costumers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Costumers_CostumerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CostumerId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "CostumerId",
                table: "Orders",
                newName: "MyProperty");

            migrationBuilder.CreateTable(
                name: "OrderCostumers",
                columns: table => new
                {
                    CostumerId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCostumers", x => new { x.CostumerId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderCostumers_Costumers_CostumerId",
                        column: x => x.CostumerId,
                        principalTable: "Costumers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderCostumers_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderCostumers_OrderId",
                table: "OrderCostumers",
                column: "OrderId");
        }
    }
}
