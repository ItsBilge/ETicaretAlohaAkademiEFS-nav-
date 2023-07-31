using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretAlohaAkademiEFSınavı.Migrations
{
    /// <inheritdoc />
    public partial class orderCostumerRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderCostumers",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CostumerId = table.Column<int>(type: "int", nullable: false)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderCostumers");
        }
    }
}
