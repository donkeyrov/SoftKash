using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanMgt.UI.Data.Migrations
{
    public partial class addedordertorepaymentorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileModules");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.AddColumn<int>(
                name: "OrderNo",
                table: "RepaymentOrder",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderNo",
                table: "RepaymentOrder");

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    ProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ProfileId);
                });

            migrationBuilder.CreateTable(
                name: "ProfileModules",
                columns: table => new
                {
                    ProfileModuleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    ProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileModules", x => x.ProfileModuleId);
                    table.ForeignKey(
                        name: "FK_ProfileModules_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfileModules_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfileModules_MenuId",
                table: "ProfileModules",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileModules_ProfileId",
                table: "ProfileModules",
                column: "ProfileId");
        }
    }
}
