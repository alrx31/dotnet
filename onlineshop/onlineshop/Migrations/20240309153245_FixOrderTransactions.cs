using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace onlineshop.Migrations
{
    /// <inheritdoc />
    public partial class FixOrderTransactions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderTransactions_Orders_OrderId",
                table: "OrderTransactions");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderTransactions",
                newName: "POrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTransactions_Orders_POrderId",
                table: "OrderTransactions",
                column: "POrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderTransactions_Orders_POrderId",
                table: "OrderTransactions");

            migrationBuilder.RenameColumn(
                name: "POrderId",
                table: "OrderTransactions",
                newName: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTransactions_Orders_OrderId",
                table: "OrderTransactions",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
