using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcRestaurant.Data.Migrations
{
    public partial class serverProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Servers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Servers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Servers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Servers");
        }
    }
}
