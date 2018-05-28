using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MappedModel.Migrations
{
    public partial class Computedandunmapped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SystemAge",
                table: "Students",
                nullable: true,
                computedColumnSql: "age(CURRENT_TIMESTAMP,DateOfBirth)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SystemAge",
                table: "Students");
        }
    }
}
