using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Relationships.Migrations
{
    public partial class Relationshps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<Guid>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    FeesOutstanding = table.Column<decimal>(type: "numeric (20,8)", nullable: false),
                    FullNames = table.Column<string>(maxLength: 100, nullable: false),
                    Gender = table.Column<string>(maxLength: 1, nullable: false, defaultValue: "M"),
                    Height = table.Column<decimal>(nullable: false),
                    Surname = table.Column<string>(maxLength: 100, nullable: false),
                    SystemAge = table.Column<string>(nullable: true, computedColumnSql: "age(CURRENT_TIMESTAMP,DateOfBirth)"),
                    WGHT = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Sibling",
                columns: table => new
                {
                    SiblingID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StudentID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sibling", x => x.SiblingID);
                    table.ForeignKey(
                        name: "FK_Sibling_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sibling_StudentID",
                table: "Sibling",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sibling");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
