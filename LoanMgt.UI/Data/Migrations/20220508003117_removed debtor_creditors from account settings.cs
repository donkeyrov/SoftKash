using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanMgt.UI.Data.Migrations
{
    public partial class removeddebtor_creditorsfromaccountsettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultCreditorsAcc",
                table: "AccountSettings");

            migrationBuilder.DropColumn(
                name: "DefaultDebtorsAcc",
                table: "AccountSettings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DefaultCreditorsAcc",
                table: "AccountSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DefaultDebtorsAcc",
                table: "AccountSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
