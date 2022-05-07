using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanMgt.UI.Data.Migrations
{
    public partial class UpdatedAccountSettingsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DefaultExpenseAcc",
                table: "AccountSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DefaultIncomeAcc",
                table: "AccountSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultExpenseAcc",
                table: "AccountSettings");

            migrationBuilder.DropColumn(
                name: "DefaultIncomeAcc",
                table: "AccountSettings");
        }
    }
}
