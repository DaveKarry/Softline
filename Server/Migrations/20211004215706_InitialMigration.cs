using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Softline.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Midname = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    MaternityLeave = table.Column<bool>(type: "bit", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employers");
        }
    }
}
