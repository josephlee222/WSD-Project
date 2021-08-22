using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WSD_Project_CC2004V_Team02.Migrations
{
    public partial class orders_add_time : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Delivery_Time",
                table: "Orders",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Delivery_Time",
                table: "Orders");
        }
    }
}
