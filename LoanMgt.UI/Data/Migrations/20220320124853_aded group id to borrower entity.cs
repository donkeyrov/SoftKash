using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanMgt.UI.Data.Migrations
{
    public partial class adedgroupidtoborrowerentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Borrowers_GroupLeaderId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_GroupLeaderId",
                table: "Groups");

            migrationBuilder.AddColumn<int>(
                name: "GroupLeaderBorrowerId",
                table: "Groups",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Borrowers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_GroupLeaderBorrowerId",
                table: "Groups",
                column: "GroupLeaderBorrowerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Borrowers_GroupLeaderBorrowerId",
                table: "Groups",
                column: "GroupLeaderBorrowerId",
                principalTable: "Borrowers",
                principalColumn: "BorrowerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Borrowers_GroupLeaderBorrowerId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_GroupLeaderBorrowerId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "GroupLeaderBorrowerId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Borrowers");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_GroupLeaderId",
                table: "Groups",
                column: "GroupLeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Borrowers_GroupLeaderId",
                table: "Groups",
                column: "GroupLeaderId",
                principalTable: "Borrowers",
                principalColumn: "BorrowerId");
        }
    }
}
