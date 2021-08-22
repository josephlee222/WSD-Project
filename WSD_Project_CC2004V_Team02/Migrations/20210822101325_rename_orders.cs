using Microsoft.EntityFrameworkCore.Migrations;

namespace WSD_Project_CC2004V_Team02.Migrations
{
    public partial class rename_orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Orders",
                newName: "Customer_Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Customer_Name",
                table: "Orders",
                newName: "CustomerName");
        }
    }
}
