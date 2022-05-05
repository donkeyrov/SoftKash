using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoanMgt.UI.Data.Migrations
{
    public partial class updateAccountSettingsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Investors");

            migrationBuilder.DropColumn(
                name: "LoansDueToday",
                table: "AccountSettings");

            migrationBuilder.DropColumn(
                name: "LoansExpiringtoday",
                table: "AccountSettings");

            migrationBuilder.DropColumn(
                name: "LoansPastMaturityDate",
                table: "AccountSettings");

            migrationBuilder.DropColumn(
                name: "NewLoansAdded",
                table: "AccountSettings");

            migrationBuilder.DropColumn(
                name: "NewRepaymentsAdded",
                table: "AccountSettings");

            migrationBuilder.RenameColumn(
                name: "YearlyLoanRepaymentCycle",
                table: "AccountSettings",
                newName: "MoxPeriodNonPerforming");

            migrationBuilder.RenameColumn(
                name: "MonthlyLoanRepaymentCycle",
                table: "AccountSettings",
                newName: "DefaultTaxAcc");

            migrationBuilder.RenameColumn(
                name: "DaysInYearInterestCalculation",
                table: "AccountSettings",
                newName: "DefaultSalesAccount");

            migrationBuilder.RenameColumn(
                name: "DaysInMonthInterestCalculation",
                table: "AccountSettings",
                newName: "DefaultReceivablesAcc");

            migrationBuilder.RenameColumn(
                name: "DateFormat",
                table: "AccountSettings",
                newName: "CompanyCode");

            migrationBuilder.RenameColumn(
                name: "CurrencyId",
                table: "AccountSettings",
                newName: "DefaultPurchasesAcc");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "AccountSettings",
                newName: "DefaultPayablesAcc");

            migrationBuilder.AddColumn<DateTime>(
                name: "LoanEnd",
                table: "Loans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LoanStart",
                table: "Loans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DefaultBadDebtAcc",
                table: "AccountSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DefaultBankAcc",
                table: "AccountSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DefaultCashAcc",
                table: "AccountSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoanEnd",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "LoanStart",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "DefaultBadDebtAcc",
                table: "AccountSettings");

            migrationBuilder.DropColumn(
                name: "DefaultBankAcc",
                table: "AccountSettings");

            migrationBuilder.DropColumn(
                name: "DefaultCashAcc",
                table: "AccountSettings");

            migrationBuilder.RenameColumn(
                name: "MoxPeriodNonPerforming",
                table: "AccountSettings",
                newName: "YearlyLoanRepaymentCycle");

            migrationBuilder.RenameColumn(
                name: "DefaultTaxAcc",
                table: "AccountSettings",
                newName: "MonthlyLoanRepaymentCycle");

            migrationBuilder.RenameColumn(
                name: "DefaultSalesAccount",
                table: "AccountSettings",
                newName: "DaysInYearInterestCalculation");

            migrationBuilder.RenameColumn(
                name: "DefaultReceivablesAcc",
                table: "AccountSettings",
                newName: "DaysInMonthInterestCalculation");

            migrationBuilder.RenameColumn(
                name: "DefaultPurchasesAcc",
                table: "AccountSettings",
                newName: "CurrencyId");

            migrationBuilder.RenameColumn(
                name: "DefaultPayablesAcc",
                table: "AccountSettings",
                newName: "CountryId");

            migrationBuilder.RenameColumn(
                name: "CompanyCode",
                table: "AccountSettings",
                newName: "DateFormat");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Investors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LoansDueToday",
                table: "AccountSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LoansExpiringtoday",
                table: "AccountSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LoansPastMaturityDate",
                table: "AccountSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NewLoansAdded",
                table: "AccountSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NewRepaymentsAdded",
                table: "AccountSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
