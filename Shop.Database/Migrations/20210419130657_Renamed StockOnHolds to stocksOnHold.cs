using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Database.Migrations
{
    public partial class RenamedStockOnHoldstostocksOnHold : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockOnHolds_Stock_StockId",
                table: "StockOnHolds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockOnHolds",
                table: "StockOnHolds");

            migrationBuilder.RenameTable(
                name: "StockOnHolds",
                newName: "StocksOnHold");

            migrationBuilder.RenameIndex(
                name: "IX_StockOnHolds_StockId",
                table: "StocksOnHold",
                newName: "IX_StocksOnHold_StockId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StocksOnHold",
                table: "StocksOnHold",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StocksOnHold_Stock_StockId",
                table: "StocksOnHold",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StocksOnHold_Stock_StockId",
                table: "StocksOnHold");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StocksOnHold",
                table: "StocksOnHold");

            migrationBuilder.RenameTable(
                name: "StocksOnHold",
                newName: "StockOnHolds");

            migrationBuilder.RenameIndex(
                name: "IX_StocksOnHold_StockId",
                table: "StockOnHolds",
                newName: "IX_StockOnHolds_StockId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockOnHolds",
                table: "StockOnHolds",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockOnHolds_Stock_StockId",
                table: "StockOnHolds",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
