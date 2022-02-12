using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanMgt.UI.Data.Migrations
{
    public partial class updatedborrowerentity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_Gender_GenderId",
                table: "Borrowers");

            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_Statuses_StatusId",
                table: "Borrowers");

            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_Titles_TitleId",
                table: "Borrowers");

            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_WorkingStatuses_WorkingStatusId",
                table: "Borrowers");

            migrationBuilder.AlterColumn<int>(
                name: "WorkingStatusId",
                table: "Borrowers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TitleId",
                table: "Borrowers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Borrowers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "Borrowers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "CreditScore",
                table: "Borrowers",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_Gender_GenderId",
                table: "Borrowers",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_Statuses_StatusId",
                table: "Borrowers",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_Titles_TitleId",
                table: "Borrowers",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "TitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_WorkingStatuses_WorkingStatusId",
                table: "Borrowers",
                column: "WorkingStatusId",
                principalTable: "WorkingStatuses",
                principalColumn: "WorkingStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_Gender_GenderId",
                table: "Borrowers");

            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_Statuses_StatusId",
                table: "Borrowers");

            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_Titles_TitleId",
                table: "Borrowers");

            migrationBuilder.DropForeignKey(
                name: "FK_Borrowers_WorkingStatuses_WorkingStatusId",
                table: "Borrowers");

            migrationBuilder.AlterColumn<int>(
                name: "WorkingStatusId",
                table: "Borrowers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TitleId",
                table: "Borrowers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Borrowers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "Borrowers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "CreditScore",
                table: "Borrowers",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_Gender_GenderId",
                table: "Borrowers",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "GenderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_Statuses_StatusId",
                table: "Borrowers",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_Titles_TitleId",
                table: "Borrowers",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "TitleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowers_WorkingStatuses_WorkingStatusId",
                table: "Borrowers",
                column: "WorkingStatusId",
                principalTable: "WorkingStatuses",
                principalColumn: "WorkingStatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
