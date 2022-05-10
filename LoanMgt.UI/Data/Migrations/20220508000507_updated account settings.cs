using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanMgt.UI.Data.Migrations
{
    public partial class updatedaccountsettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Accounts_AccountId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherIncomes_Accounts_AccountId",
                table: "OtherIncomes");

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "OtherIncomes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "ApproveDate",
                table: "OtherIncomes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApprovedBy",
                table: "OtherIncomes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CrAccountId",
                table: "OtherIncomes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DrAccountId",
                table: "OtherIncomes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Posted",
                table: "OtherIncomes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "OtherIncomes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "Expenses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "ApproveDate",
                table: "Expenses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApprovedBy",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CrAccountId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DrAccountId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Posted",
                table: "Expenses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DefaultCreditorsAcc",
                table: "AccountSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DefaultDebtorsAcc",
                table: "AccountSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LoanTransactionCode",
                table: "AccountSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Accounts_AccountId",
                table: "Expenses",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_OtherIncomes_Accounts_AccountId",
                table: "OtherIncomes",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Accounts_AccountId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherIncomes_Accounts_AccountId",
                table: "OtherIncomes");

            migrationBuilder.DropColumn(
                name: "ApproveDate",
                table: "OtherIncomes");

            migrationBuilder.DropColumn(
                name: "ApprovedBy",
                table: "OtherIncomes");

            migrationBuilder.DropColumn(
                name: "CrAccountId",
                table: "OtherIncomes");

            migrationBuilder.DropColumn(
                name: "DrAccountId",
                table: "OtherIncomes");

            migrationBuilder.DropColumn(
                name: "Posted",
                table: "OtherIncomes");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "OtherIncomes");

            migrationBuilder.DropColumn(
                name: "ApproveDate",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ApprovedBy",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "CrAccountId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "DrAccountId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "Posted",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "DefaultCreditorsAcc",
                table: "AccountSettings");

            migrationBuilder.DropColumn(
                name: "DefaultDebtorsAcc",
                table: "AccountSettings");

            migrationBuilder.DropColumn(
                name: "LoanTransactionCode",
                table: "AccountSettings");

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "OtherIncomes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Accounts_AccountId",
                table: "Expenses",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OtherIncomes_Accounts_AccountId",
                table: "OtherIncomes",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
