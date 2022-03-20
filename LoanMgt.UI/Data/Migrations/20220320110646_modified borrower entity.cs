using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanMgt.UI.Data.Migrations
{
    public partial class modifiedborrowerentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeNo",
                table: "Borrowers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeNo",
                table: "Borrowers");
        }
    }
}
