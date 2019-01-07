using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManager.Migrations
{
    public partial class AddMicredential : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyCredentials",
                columns: table => new
                {
                    AccessToken = table.Column<string>(nullable: false),
                    OwnId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: false),
                    ExpiredAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyCredentials", x => x.AccessToken);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyCredentials");
        }
    }
}
