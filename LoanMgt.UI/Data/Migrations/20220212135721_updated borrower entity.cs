using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanMgt.UI.Data.Migrations
{
    public partial class updatedborrowerentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Borrowers_GroupLeaderId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "WorkingStatus",
                table: "Borrowers");

            migrationBuilder.AlterColumn<int>(
                name: "GroupLeaderId",
                table: "Groups",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkingStatusId",
                table: "Borrowers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_WorkingStatusId",
                table: "Borrowers",
                column: "WorkingStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_WorkingStatuses_WorkingStatusId",
                table: "Borrowers",
                column: "WorkingStatusId",
                principalTable: "WorkingStatuses",
                principalColumn: "WorkingStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Borrowers_GroupLeaderId",
                table: "Groups",
                column: "GroupLeaderId",
                principalTable: "Borrowers",
                principalColumn: "BorrowerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_WorkingStatuses_WorkingStatusId",
                table: "Borrowers");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Borrowers_GroupLeaderId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Borrowers_WorkingStatusId",
                table: "Borrowers");

            migrationBuilder.DropColumn(
                name: "WorkingStatusId",
                table: "Borrowers");

            migrationBuilder.AlterColumn<int>(
                name: "GroupLeaderId",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "WorkingStatus",
                table: "Borrowers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Borrowers_GroupLeaderId",
                table: "Groups",
                column: "GroupLeaderId",
                principalTable: "Borrowers",
                principalColumn: "BorrowerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
