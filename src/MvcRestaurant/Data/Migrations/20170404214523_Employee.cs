using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MvcRestaurant.Data.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Servers",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "age",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Servers");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Servers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Servers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "tips",
                table: "Servers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servers",
                table: "Servers",
                column: "ID");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Servers",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Servers",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "tips",
                table: "Servers");

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "Servers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Servers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Servers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servers",
                table: "Servers",
                column: "ServerId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Servers",
                newName: "name");
        }
    }
}
