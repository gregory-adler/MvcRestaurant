using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcRestaurant.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employee",
                column: "ID");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employees",
                column: "ID");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");
        }
    }
}
