﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Bug_Tracker.Migrations
{
    public partial class addedstatustobug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Bugs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Bugs");
        }
    }
}
