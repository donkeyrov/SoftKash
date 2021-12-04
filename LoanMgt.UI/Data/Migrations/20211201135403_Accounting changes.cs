using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanMgt.UI.Data.Migrations
{
    public partial class Accountingchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Credit",
                table: "AccountTypes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Debit",
                table: "AccountTypes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Credit",
                table: "AccountTypes");

            migrationBuilder.DropColumn(
                name: "Debit",
                table: "AccountTypes");
        }
    }
}
