using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hello_Sarkar.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssuedDate = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<string>(maxLength: 20, nullable: false),
                    District = table.Column<int>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    Place = table.Column<string>(nullable: false),
                    IssueDetails = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Info = table.Column<string>(nullable: false),
                    Source = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
