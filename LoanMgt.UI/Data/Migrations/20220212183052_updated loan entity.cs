using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanMgt.UI.Data.Migrations
{
    public partial class updatedloanentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BorrowerId",
                table: "Loans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BorrowerId",
                table: "Loans",
                column: "BorrowerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Borrowers_BorrowerId",
                table: "Loans",
                column: "BorrowerId",
                principalTable: "Borrowers",
                principalColumn: "BorrowerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Borrowers_BorrowerId",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_BorrowerId",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "BorrowerId",
                table: "Loans");
        }
    }
}
