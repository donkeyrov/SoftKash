using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanMgt.UI.Data.Migrations
{
    public partial class updatedaccounttypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BalanceSheetAccount",
                table: "AccountTypes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BalanceSheetAccount",
                table: "AccountTypes");
        }
    }
}
