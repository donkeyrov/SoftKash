using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanMgt.UI.Data.Migrations
{
    public partial class addedloansummarytoloanentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "EffectivePA",
                table: "Loans",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TotalDue",
                table: "Loans",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TotalReturn",
                table: "Loans",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TotalReturnPA",
                table: "Loans",
                type: "real",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EffectivePA",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "TotalDue",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "TotalReturn",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "TotalReturnPA",
                table: "Loans");
        }
    }
}
