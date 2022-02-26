using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanMgt.UI.Data.Migrations
{
    public partial class changedloanFeeentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LoanFees_FeeId",
                table: "LoanFees",
                column: "FeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanFees_Fees_FeeId",
                table: "LoanFees",
                column: "FeeId",
                principalTable: "Fees",
                principalColumn: "FeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanFees_Fees_FeeId",
                table: "LoanFees");

            migrationBuilder.DropIndex(
                name: "IX_LoanFees_FeeId",
                table: "LoanFees");
        }
    }
}
