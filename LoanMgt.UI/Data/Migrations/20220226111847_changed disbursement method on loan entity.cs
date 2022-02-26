using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanMgt.UI.Data.Migrations
{
    public partial class changeddisbursementmethodonloanentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_DisbursementMethod_DisbursementMethodId",
                table: "Loans");

            migrationBuilder.AlterColumn<int>(
                name: "DisbursementMethodId",
                table: "Loans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Cash",
                table: "Loans",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cheque",
                table: "Loans",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OnlineTransfer",
                table: "Loans",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_DisbursementMethod_DisbursementMethodId",
                table: "Loans",
                column: "DisbursementMethodId",
                principalTable: "DisbursementMethod",
                principalColumn: "DisbursementMethodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_DisbursementMethod_DisbursementMethodId",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "Cash",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "Cheque",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "OnlineTransfer",
                table: "Loans");

            migrationBuilder.AlterColumn<int>(
                name: "DisbursementMethodId",
                table: "Loans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_DisbursementMethod_DisbursementMethodId",
                table: "Loans",
                column: "DisbursementMethodId",
                principalTable: "DisbursementMethod",
                principalColumn: "DisbursementMethodId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
