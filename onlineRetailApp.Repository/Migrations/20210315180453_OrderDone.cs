using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineRetailApp.Repository.Migrations
{
    public partial class OrderDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(maxLength: 15, nullable: false),
                    CustomerId = table.Column<Guid>(maxLength: 15, nullable: false),
                    Quantity = table.Column<int>(maxLength: 15, nullable: false),
                    OrderedDate = table.Column<DateTime>(nullable: false),
                    ShippingDate = table.Column<DateTime>(nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(12,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
