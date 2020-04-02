using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreData.Migrations
{
    public partial class AddMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<Guid>(nullable: false),
                    MenuName = table.Column<string>(nullable: true),
                    MenuCode = table.Column<string>(nullable: true),
                    ParentId = table.Column<Guid>(nullable: true),
                    RootId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
