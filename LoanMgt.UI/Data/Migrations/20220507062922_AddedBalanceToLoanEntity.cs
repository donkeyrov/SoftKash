using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanMgt.UI.Data.Migrations
{
    public partial class AddedBalanceToLoanEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Balance",
                table: "Loans",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Loans");
        }
    }
}
