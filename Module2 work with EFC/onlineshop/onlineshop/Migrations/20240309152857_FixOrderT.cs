using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace onlineshop.Migrations
{
    /// <inheritdoc />
    public partial class FixOrderT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Transaction Updated At",
                table: "OrderTransactions",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Transaction Updated At",
                table: "OrderTransactions",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);
        }
    }
}
