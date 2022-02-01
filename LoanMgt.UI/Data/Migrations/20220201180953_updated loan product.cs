using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanMgt.UI.Data.Migrations
{
    public partial class updatedloanproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanProducts_interestMethods_InterestMethodId",
                table: "LoanProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanProducts_LoanDurations_LoanDurationId",
                table: "LoanProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanProducts_loanInterestPeriods_LoanInterestPeriodId",
                table: "LoanProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanProducts_RepaymentCycles_RepaymentCycleId",
                table: "LoanProducts");

            migrationBuilder.AlterColumn<int>(
                name: "RepaymentCycleId",
                table: "LoanProducts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LoanInterestPeriodId",
                table: "LoanProducts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LoanDurationId",
                table: "LoanProducts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InterestMethodId",
                table: "LoanProducts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanProducts_interestMethods_InterestMethodId",
                table: "LoanProducts",
                column: "InterestMethodId",
                principalTable: "interestMethods",
                principalColumn: "InterestMethodId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanProducts_LoanDurations_LoanDurationId",
                table: "LoanProducts",
                column: "LoanDurationId",
                principalTable: "LoanDurations",
                principalColumn: "LoanDurationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanProducts_loanInterestPeriods_LoanInterestPeriodId",
                table: "LoanProducts",
                column: "LoanInterestPeriodId",
                principalTable: "loanInterestPeriods",
                principalColumn: "LoanInterestPeriodId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanProducts_RepaymentCycles_RepaymentCycleId",
                table: "LoanProducts",
                column: "RepaymentCycleId",
                principalTable: "RepaymentCycles",
                principalColumn: "RepaymentCycleId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanProducts_interestMethods_InterestMethodId",
                table: "LoanProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanProducts_LoanDurations_LoanDurationId",
                table: "LoanProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanProducts_loanInterestPeriods_LoanInterestPeriodId",
                table: "LoanProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanProducts_RepaymentCycles_RepaymentCycleId",
                table: "LoanProducts");

            migrationBuilder.AlterColumn<int>(
                name: "RepaymentCycleId",
                table: "LoanProducts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LoanInterestPeriodId",
                table: "LoanProducts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LoanDurationId",
                table: "LoanProducts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InterestMethodId",
                table: "LoanProducts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanProducts_interestMethods_InterestMethodId",
                table: "LoanProducts",
                column: "InterestMethodId",
                principalTable: "interestMethods",
                principalColumn: "InterestMethodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanProducts_LoanDurations_LoanDurationId",
                table: "LoanProducts",
                column: "LoanDurationId",
                principalTable: "LoanDurations",
                principalColumn: "LoanDurationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanProducts_loanInterestPeriods_LoanInterestPeriodId",
                table: "LoanProducts",
                column: "LoanInterestPeriodId",
                principalTable: "loanInterestPeriods",
                principalColumn: "LoanInterestPeriodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanProducts_RepaymentCycles_RepaymentCycleId",
                table: "LoanProducts",
                column: "RepaymentCycleId",
                principalTable: "RepaymentCycles",
                principalColumn: "RepaymentCycleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
