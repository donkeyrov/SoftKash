using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanMgt.UI.Data.Migrations
{
    public partial class newassetmgttype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetManagementTypes",
                columns: table => new
                {
                    AssetManagementTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetManagementTypes", x => x.AssetManagementTypeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetManagementTypes");
        }
    }
}
