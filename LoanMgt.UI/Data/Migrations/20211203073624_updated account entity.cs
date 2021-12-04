using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanMgt.UI.Data.Migrations
{
    public partial class updatedaccountentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Accounts");

            migrationBuilder.AddColumn<float>(
                name: "Credit",
                table: "Accounts",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Debit",
                table: "Accounts",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Credit",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Debit",
                table: "Accounts");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
