using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineRetailApp.Repository.Migrations
{
    public partial class order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(12,3)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
