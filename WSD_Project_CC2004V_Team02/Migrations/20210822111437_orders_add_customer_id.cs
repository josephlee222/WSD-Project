using Microsoft.EntityFrameworkCore.Migrations;

namespace WSD_Project_CC2004V_Team02.Migrations
{
    public partial class orders_add_customer_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Customer_ID",
                table: "Orders",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Customer_ID",
                table: "Orders");
        }
    }
}
