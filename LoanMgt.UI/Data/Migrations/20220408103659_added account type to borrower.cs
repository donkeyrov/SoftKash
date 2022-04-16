using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanMgt.UI.Data.Migrations
{
    public partial class addedaccounttypetoborrower : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountTypeId",
                table: "Borrowers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_AccountTypeId",
                table: "Borrowers",
                column: "AccountTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_AccountTypes_AccountTypeId",
                table: "Borrowers",
                column: "AccountTypeId",
                principalTable: "AccountTypes",
                principalColumn: "AccountTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_AccountTypes_AccountTypeId",
                table: "Borrowers");

            migrationBuilder.DropIndex(
                name: "IX_Borrowers_AccountTypeId",
                table: "Borrowers");

            migrationBuilder.DropColumn(
                name: "AccountTypeId",
                table: "Borrowers");
        }
    }
}
