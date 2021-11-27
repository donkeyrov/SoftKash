using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanMgt.UI.Data.Migrations
{
    public partial class initialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AccountSettings",
                columns: table => new
                {
                    AccountSettingsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    DateFormat = table.Column<string>(nullable: true),
                    MonthlyLoanRepaymentCycle = table.Column<int>(nullable: false),
                    YearlyLoanRepaymentCycle = table.Column<int>(nullable: false),
                    DaysInMonthInterestCalculation = table.Column<int>(nullable: false),
                    DaysInYearInterestCalculation = table.Column<int>(nullable: false),
                    LoansDueToday = table.Column<bool>(nullable: false),
                    LoansExpiringtoday = table.Column<bool>(nullable: false),
                    LoansPastMaturityDate = table.Column<bool>(nullable: false),
                    NewLoansAdded = table.Column<bool>(nullable: false),
                    NewRepaymentsAdded = table.Column<bool>(nullable: false),
                    Logo = table.Column<byte[]>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountSettings", x => x.AccountSettingsId);
                });

            migrationBuilder.CreateTable(
                name: "AccountTypes",
                columns: table => new
                {
                    AccountTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: false),
                    Desciption = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTypes", x => x.AccountTypeId);
                });

            migrationBuilder.CreateTable(
                name: "BankBranches",
                columns: table => new
                {
                    BankBranchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankId = table.Column<int>(nullable: false),
                    SortCode = table.Column<string>(nullable: true),
                    TownId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankBranches", x => x.BankBranchId);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    BankId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.BankId);
                });

            migrationBuilder.CreateTable(
                name: "CollateralTypes",
                columns: table => new
                {
                    CollateralTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollateralTypes", x => x.CollateralTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    CurrencyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyCode = table.Column<string>(nullable: true),
                    CurrencyName = table.Column<string>(nullable: true),
                    CurrencySymbol = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.CurrencyId);
                });

            migrationBuilder.CreateTable(
                name: "DisbursementMethod",
                columns: table => new
                {
                    DisbursementMethodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisbursementMethod", x => x.DisbursementMethodId);
                });

            migrationBuilder.CreateTable(
                name: "Fees",
                columns: table => new
                {
                    FeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Fixedamount = table.Column<bool>(nullable: false),
                    PercentageBased = table.Column<bool>(nullable: false),
                    CalculateOnDuePrincipalAmount = table.Column<bool>(nullable: false),
                    CalculateOnDueInterestamount = table.Column<bool>(nullable: false),
                    CalculateOnDuePricipalAndInterest = table.Column<bool>(nullable: false),
                    DeductFromPrincipalAmount = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fees", x => x.FeeId);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "GuarantorFiles",
                columns: table => new
                {
                    GuarantorFileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuarantorId = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    ActualFile = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuarantorFiles", x => x.GuarantorFileId);
                });

            migrationBuilder.CreateTable(
                name: "Guarantors",
                columns: table => new
                {
                    GuarantorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    BusinessName = table.Column<string>(nullable: true),
                    UniqueNumber = table.Column<string>(nullable: true),
                    NRC = table.Column<string>(nullable: true),
                    GenderId = table.Column<int>(nullable: false),
                    TitleId = table.Column<int>(nullable: false),
                    Mobile = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    TownId = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false),
                    ZipCode = table.Column<string>(nullable: true),
                    LandLinePhone = table.Column<string>(nullable: true),
                    WorkingStatusId = table.Column<int>(nullable: false),
                    Photo = table.Column<byte[]>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantors", x => x.GuarantorId);
                });

            migrationBuilder.CreateTable(
                name: "interestMethods",
                columns: table => new
                {
                    InterestMethodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_interestMethods", x => x.InterestMethodId);
                });

            migrationBuilder.CreateTable(
                name: "LoanDurations",
                columns: table => new
                {
                    LoanDurationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanDurations", x => x.LoanDurationId);
                });

            migrationBuilder.CreateTable(
                name: "LoanFees",
                columns: table => new
                {
                    LoanFeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanId = table.Column<int>(nullable: false),
                    FeeId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanFees", x => x.LoanFeeId);
                });

            migrationBuilder.CreateTable(
                name: "LoanFiles",
                columns: table => new
                {
                    LoanFileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanId = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    ActualFile = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanFiles", x => x.LoanFileId);
                });

            migrationBuilder.CreateTable(
                name: "loanGuarantors",
                columns: table => new
                {
                    LoanGuarantorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanId = table.Column<int>(nullable: false),
                    GuarantorId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loanGuarantors", x => x.LoanGuarantorId);
                });

            migrationBuilder.CreateTable(
                name: "loanInterestPeriods",
                columns: table => new
                {
                    LoanInterestPeriodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loanInterestPeriods", x => x.LoanInterestPeriodId);
                });

            migrationBuilder.CreateTable(
                name: "LoanPenalties",
                columns: table => new
                {
                    LoanPenaltyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanId = table.Column<int>(nullable: false),
                    PenaltyId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanPenalties", x => x.LoanPenaltyId);
                });

            migrationBuilder.CreateTable(
                name: "LoanStatuses",
                columns: table => new
                {
                    LoanStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanStatuses", x => x.LoanStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    ParentMenuId = table.Column<int>(nullable: false),
                    SubText = table.Column<string>(nullable: true),
                    Target = table.Column<string>(nullable: true),
                    MenuURL = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    IconName = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "OtherIncomeTypes",
                columns: table => new
                {
                    OtherIncomeTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherIncomeTypes", x => x.OtherIncomeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Penalties",
                columns: table => new
                {
                    PenaltyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enabled = table.Column<bool>(nullable: false),
                    PercentageBased = table.Column<bool>(nullable: false),
                    FixedAmount = table.Column<bool>(nullable: false),
                    CalculateOn = table.Column<string>(nullable: true),
                    WaivePenaltyOnHolidays = table.Column<bool>(nullable: false),
                    InterestRate = table.Column<float>(nullable: false),
                    GracePeriod = table.Column<int>(nullable: false),
                    RecurringPenaltyInterestRate = table.Column<float>(nullable: false),
                    MyProperty = table.Column<int>(nullable: false),
                    RecurringPeriod = table.Column<int>(nullable: false),
                    RecurringPeriodType = table.Column<int>(nullable: false),
                    LoanScheduleDescription = table.Column<string>(nullable: true),
                    EnableAfterMaturity = table.Column<bool>(nullable: false),
                    MaturityPercentageBased = table.Column<bool>(nullable: false),
                    MaturityFixedAmount = table.Column<bool>(nullable: false),
                    MaturityCalculateOn = table.Column<string>(nullable: true),
                    MaturityWaivePenaltyOnHolidays = table.Column<bool>(nullable: false),
                    MaturityPenaltyInterestRate = table.Column<float>(nullable: false),
                    MaturityGracePeriod = table.Column<int>(nullable: false),
                    MaturityRecurringPenaltyInterestRate = table.Column<float>(nullable: false),
                    MaturityRecurringPeriod = table.Column<int>(nullable: false),
                    MaturityRecurringPeriodType = table.Column<int>(nullable: false),
                    MaturityLoanScheduleDescription = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penalties", x => x.PenaltyId);
                });

            migrationBuilder.CreateTable(
                name: "PenaltyLoanStatuses",
                columns: table => new
                {
                    PenaltyLoanStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PenaltyId = table.Column<int>(nullable: false),
                    LoanStatusId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenaltyLoanStatuses", x => x.PenaltyLoanStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    ProfileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ProfileId);
                });

            migrationBuilder.CreateTable(
                name: "RepaymentCycles",
                columns: table => new
                {
                    RepaymentCycleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FixedDays = table.Column<bool>(nullable: false),
                    FixedDates = table.Column<bool>(nullable: false),
                    NumberOfDays = table.Column<int>(nullable: false),
                    ManualDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepaymentCycles", x => x.RepaymentCycleId);
                });

            migrationBuilder.CreateTable(
                name: "RepaymentOrder",
                columns: table => new
                {
                    RepaymentOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanProductId = table.Column<int>(nullable: false),
                    FeeId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepaymentOrder", x => x.RepaymentOrderId);
                });

            migrationBuilder.CreateTable(
                name: "Sequences",
                columns: table => new
                {
                    SequenceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SeqNumber = table.Column<string>(nullable: true),
                    Step = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sequences", x => x.SequenceId);
                });

            migrationBuilder.CreateTable(
                name: "StaffDailyReports",
                columns: table => new
                {
                    StaffDailyReportsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffDailyReports", x => x.StaffDailyReportsId);
                });

            migrationBuilder.CreateTable(
                name: "StaffWeeklyReports",
                columns: table => new
                {
                    StaffWeeklyReportsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffWeeklyReports", x => x.StaffWeeklyReportsId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "TaxTypes",
                columns: table => new
                {
                    TaxTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TaxPercentage = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxTypes", x => x.TaxTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    TitleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.TitleId);
                });

            migrationBuilder.CreateTable(
                name: "UserSessions",
                columns: table => new
                {
                    UserSessionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    MachineName = table.Column<string>(nullable: true),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSessions", x => x.UserSessionId);
                    table.ForeignKey(
                        name: "FK_UserSessions_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkingStatuses",
                columns: table => new
                {
                    WorkingStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingStatuses", x => x.WorkingStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountTypeId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    AccountName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Accounts_AccountTypes_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountTypes",
                        principalColumn: "AccountTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceId);
                    table.ForeignKey(
                        name: "FK_Provinces_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfileModules",
                columns: table => new
                {
                    ProfileModuleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<int>(nullable: false),
                    MenuId = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileModules", x => x.ProfileModuleId);
                    table.ForeignKey(
                        name: "FK_ProfileModules_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfileModules_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanProducts",
                columns: table => new
                {
                    LoanProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Cash = table.Column<bool>(nullable: false),
                    Cheque = table.Column<bool>(nullable: false),
                    OnlineTransfer = table.Column<bool>(nullable: false),
                    MinimumPrincipalAmount = table.Column<float>(nullable: false),
                    DefaultPrincipalAmount = table.Column<float>(nullable: false),
                    MaximumPrincipalAmount = table.Column<float>(nullable: false),
                    InterestMethodId = table.Column<int>(nullable: false),
                    InterestIsPercentageBased = table.Column<bool>(nullable: false),
                    InterestIsFixedAmountPerCycle = table.Column<bool>(nullable: false),
                    LoanInterestPeriodId = table.Column<int>(nullable: false),
                    MinimumLoanInterestRate = table.Column<float>(nullable: false),
                    DefaultLoanInterestRate = table.Column<float>(nullable: false),
                    MaximumLoanInterestRate = table.Column<float>(nullable: false),
                    LoanDurationId = table.Column<int>(nullable: false),
                    MinimumLoanDuration = table.Column<int>(nullable: false),
                    DefaultLoanDuration = table.Column<int>(nullable: false),
                    MaximumLoanDuration = table.Column<int>(nullable: false),
                    RepaymentCycleId = table.Column<int>(nullable: false),
                    MinimumNumberOfRePayments = table.Column<int>(nullable: false),
                    DefaultNumberOfRePayments = table.Column<int>(nullable: false),
                    MaximumNumberOfRepayments = table.Column<int>(nullable: false),
                    RepaymentOrder = table.Column<string>(nullable: true),
                    ExtendAfterMaturity = table.Column<bool>(nullable: false),
                    MaturityInterestIsPercentageBased = table.Column<bool>(nullable: false),
                    MaturityInterestIsFixedAmount = table.Column<bool>(nullable: false),
                    CalculateInterestOn = table.Column<string>(nullable: true),
                    InterestRateAfterMaturity = table.Column<float>(nullable: false),
                    RecurringPeriodAfterMaturity = table.Column<int>(nullable: false),
                    DurationAfterMaturity = table.Column<int>(nullable: false),
                    PastMaturityLoanStatus = table.Column<int>(nullable: false),
                    FirstRepaymentAmount = table.Column<float>(nullable: false),
                    lastRepaymentAmount = table.Column<float>(nullable: false),
                    OverrideRepaymentAmountTo = table.Column<float>(nullable: false),
                    ProRataInterestCalculation = table.Column<bool>(nullable: false),
                    LoanScheduleDescription = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DisbursementMethodId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanProducts", x => x.LoanProductId);
                    table.ForeignKey(
                        name: "FK_LoanProducts_DisbursementMethod_DisbursementMethodId",
                        column: x => x.DisbursementMethodId,
                        principalTable: "DisbursementMethod",
                        principalColumn: "DisbursementMethodId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoanProducts_interestMethods_InterestMethodId",
                        column: x => x.InterestMethodId,
                        principalTable: "interestMethods",
                        principalColumn: "InterestMethodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanProducts_LoanDurations_LoanDurationId",
                        column: x => x.LoanDurationId,
                        principalTable: "LoanDurations",
                        principalColumn: "LoanDurationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanProducts_loanInterestPeriods_LoanInterestPeriodId",
                        column: x => x.LoanInterestPeriodId,
                        principalTable: "loanInterestPeriods",
                        principalColumn: "LoanInterestPeriodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanProducts_RepaymentCycles_RepaymentCycleId",
                        column: x => x.RepaymentCycleId,
                        principalTable: "RepaymentCycles",
                        principalColumn: "RepaymentCycleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionCodes",
                columns: table => new
                {
                    TransactionCodeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DebitAccountId = table.Column<int>(nullable: false),
                    CreditAccountId = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    MainCode = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionCodes", x => x.TransactionCodeId);
                    table.ForeignKey(
                        name: "FK_TransactionCodes_Accounts_CreditAccountId",
                        column: x => x.CreditAccountId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TransactionCodes_Accounts_DebitAccountId",
                        column: x => x.DebitAccountId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    TownId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.TownId);
                    table.ForeignKey(
                        name: "FK_Towns_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    LoanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanProductId = table.Column<int>(nullable: false),
                    LoanNumber = table.Column<int>(nullable: false),
                    DisbursementMethodId = table.Column<int>(nullable: false),
                    PrincipalAmount = table.Column<float>(nullable: false),
                    LoanReleaseDate = table.Column<DateTime>(nullable: false),
                    InterestMethodId = table.Column<int>(nullable: false),
                    InterestIsPercentageBased = table.Column<bool>(nullable: false),
                    InterestIsFixedAmountPerCycle = table.Column<bool>(nullable: false),
                    LoanInterestPeriodId = table.Column<int>(nullable: false),
                    LoanInterestRate = table.Column<float>(nullable: false),
                    LoanPeriod = table.Column<int>(nullable: false),
                    LoanDurationId = table.Column<int>(nullable: false),
                    RepaymentCycleId = table.Column<int>(nullable: false),
                    NumberOfRePayments = table.Column<int>(nullable: false),
                    InterestStartDate = table.Column<DateTime>(nullable: false),
                    FirstRePaymentDate = table.Column<DateTime>(nullable: false),
                    CalculateFirstRePaymentProRata = table.Column<bool>(nullable: false),
                    AdjustFirstRepayment = table.Column<bool>(nullable: false),
                    DoNotAdjustRemainingPayments = table.Column<bool>(nullable: false),
                    FirstRepaymentAmount = table.Column<float>(nullable: false),
                    lastRepaymentAmount = table.Column<float>(nullable: false),
                    OverrideMaturityDate = table.Column<bool>(nullable: false),
                    OverrideRepaymentAmount = table.Column<bool>(nullable: false),
                    AddAutomaticPayments = table.Column<bool>(nullable: false),
                    TimeToPostBetween = table.Column<string>(nullable: true),
                    ExttendAfterMaturity = table.Column<bool>(nullable: false),
                    InterestPercentageBased = table.Column<bool>(nullable: false),
                    InterestFixedAmount = table.Column<bool>(nullable: false),
                    CalculateInterestOn = table.Column<string>(nullable: true),
                    InterestRateAfterMaturity = table.Column<float>(nullable: false),
                    RecurringPeriodAfterMaturity = table.Column<int>(nullable: false),
                    DDurationAfterMaturity = table.Column<int>(nullable: false),
                    LoanStatusId = table.Column<int>(nullable: false),
                    LoanTitle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ApproverStage = table.Column<int>(nullable: false),
                    FirstApprover = table.Column<string>(nullable: true),
                    FirstApproverDate = table.Column<DateTime>(nullable: false),
                    SecondApprover = table.Column<string>(nullable: true),
                    SecondApproverDate = table.Column<DateTime>(nullable: false),
                    ThirdApprover = table.Column<string>(nullable: true),
                    ThirdApproverDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanId);
                    table.ForeignKey(
                        name: "FK_Loans_DisbursementMethod_DisbursementMethodId",
                        column: x => x.DisbursementMethodId,
                        principalTable: "DisbursementMethod",
                        principalColumn: "DisbursementMethodId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Loans_interestMethods_InterestMethodId",
                        column: x => x.InterestMethodId,
                        principalTable: "interestMethods",
                        principalColumn: "InterestMethodId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Loans_LoanDurations_LoanDurationId",
                        column: x => x.LoanDurationId,
                        principalTable: "LoanDurations",
                        principalColumn: "LoanDurationId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Loans_LoanProducts_LoanProductId",
                        column: x => x.LoanProductId,
                        principalTable: "LoanProducts",
                        principalColumn: "LoanProductId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Loans_LoanStatuses_LoanStatusId",
                        column: x => x.LoanStatusId,
                        principalTable: "LoanStatuses",
                        principalColumn: "LoanStatusId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Loans_RepaymentCycles_RepaymentCycleId",
                        column: x => x.RepaymentCycleId,
                        principalTable: "RepaymentCycles",
                        principalColumn: "RepaymentCycleId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Borrowers",
                columns: table => new
                {
                    BorrowerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false),
                    BusinessName = table.Column<string>(nullable: true),
                    NRC = table.Column<string>(nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    TitleId = table.Column<int>(nullable: false),
                    Mobile = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    TownId = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false),
                    ZipCode = table.Column<string>(nullable: true),
                    LandLine = table.Column<string>(nullable: true),
                    WorkingStatus = table.Column<string>(nullable: true),
                    CreditScore = table.Column<float>(nullable: false),
                    Photo = table.Column<byte[]>(nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowers", x => x.BorrowerId);
                    table.ForeignKey(
                        name: "FK_Borrowers_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Borrowers_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Borrowers_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Borrowers_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "TitleId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Borrowers_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "TownId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    TownId = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    MinLoanAmount = table.Column<float>(nullable: false),
                    MaxLoanAmount = table.Column<float>(nullable: false),
                    MinInterestRate = table.Column<float>(nullable: false),
                    MaxInterestRate = table.Column<float>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                    table.ForeignKey(
                        name: "FK_Branches_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "TownId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonDetails",
                columns: table => new
                {
                    PersonDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NRC = table.Column<string>(nullable: false),
                    TitleId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    OtherName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    TownId = table.Column<int>(nullable: false),
                    HouseNumber = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    ResidentialArea = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    CountryOfbirth = table.Column<string>(nullable: true),
                    TownOfBirth = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    PassportNo = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonDetails", x => x.PersonDetailsId);
                    table.ForeignKey(
                        name: "FK_PersonDetails_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PersonDetails_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PersonDetails_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "TitleId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PersonDetails_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "TownId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "BorrowerFiles",
                columns: table => new
                {
                    BorrowerFileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BorrowerId = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(nullable: false),
                    ActualFile = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowerFiles", x => x.BorrowerFileId);
                    table.ForeignKey(
                        name: "FK_BorrowerFiles_Borrowers_BorrowerId",
                        column: x => x.BorrowerId,
                        principalTable: "Borrowers",
                        principalColumn: "BorrowerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    GroupLeaderId = table.Column<int>(nullable: false),
                    CollectorName = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    MeetingSchedule = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Groups_Borrowers_GroupLeaderId",
                        column: x => x.GroupLeaderId,
                        principalTable: "Borrowers",
                        principalColumn: "BorrowerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchHolidays",
                columns: table => new
                {
                    BranchHolidayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    HolidayDates = table.Column<string>(nullable: true),
                    FridayBranchHoliday = table.Column<bool>(nullable: false),
                    SaturdayBranchHoliday = table.Column<bool>(nullable: false),
                    SundayBranchHoliday = table.Column<bool>(nullable: false),
                    NextDayThatIsNotHoliday = table.Column<bool>(nullable: false),
                    NextRepaymentCycle = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchHolidays", x => x.BranchHolidayId);
                    table.ForeignKey(
                        name: "FK_BranchHolidays_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Collectors",
                columns: table => new
                {
                    CollectorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collectors", x => x.CollectorId);
                    table.ForeignKey(
                        name: "FK_Collectors_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanProductBranches",
                columns: table => new
                {
                    LoanProductBranchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    LoanProductId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanProductBranches", x => x.LoanProductBranchId);
                    table.ForeignKey(
                        name: "FK_LoanProductBranches_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanProductBranches_LoanProducts_LoanProductId",
                        column: x => x.LoanProductId,
                        principalTable: "LoanProducts",
                        principalColumn: "LoanProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    AccountCode = table.Column<string>(nullable: true),
                    TransactionType = table.Column<string>(nullable: true),
                    Debit = table.Column<double>(nullable: false),
                    Credit = table.Column<double>(nullable: false),
                    Balance = table.Column<double>(nullable: false),
                    CurrencyCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TaxTypeId = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<float>(nullable: false),
                    TaxAmount = table.Column<double>(nullable: false),
                    BatchRef = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    CustomerNo = table.Column<string>(nullable: true),
                    BranchId = table.Column<int>(nullable: false),
                    Reconciled = table.Column<bool>(nullable: false),
                    Archived = table.Column<bool>(nullable: false),
                    TaxMonth = table.Column<string>(nullable: true),
                    AccountingYear = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_Transactions_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_TaxTypes_TaxTypeId",
                        column: x => x.TaxTypeId,
                        principalTable: "TaxTypes",
                        principalColumn: "TaxTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowerGroups",
                columns: table => new
                {
                    BorrowerGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BorrowerId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowerGroups", x => x.BorrowerGroupId);
                    table.ForeignKey(
                        name: "FK_BorrowerGroups_Borrowers_BorrowerId",
                        column: x => x.BorrowerId,
                        principalTable: "Borrowers",
                        principalColumn: "BorrowerId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BorrowerGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TransactionDetails",
                columns: table => new
                {
                    TransactionDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionId = table.Column<int>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    AccountCode = table.Column<string>(nullable: true),
                    TransactionCodeId = table.Column<int>(nullable: false),
                    TransactionType = table.Column<string>(nullable: true),
                    Debit = table.Column<double>(nullable: false),
                    Credit = table.Column<double>(nullable: false),
                    Balance = table.Column<double>(nullable: false),
                    CurrencyCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TaxTypeId = table.Column<int>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<float>(nullable: false),
                    TaxAmount = table.Column<double>(nullable: false),
                    BatchRef = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    CustomerNo = table.Column<string>(nullable: true),
                    BranchId = table.Column<int>(nullable: false),
                    Reconciled = table.Column<bool>(nullable: false),
                    Archived = table.Column<bool>(nullable: false),
                    TaxMonth = table.Column<string>(nullable: true),
                    AccountingYear = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionDetails", x => x.TransactionDetailsId);
                    table.ForeignKey(
                        name: "FK_TransactionDetails_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TransactionDetails_TaxTypes_TaxTypeId",
                        column: x => x.TaxTypeId,
                        principalTable: "TaxTypes",
                        principalColumn: "TaxTypeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TransactionDetails_TransactionCodes_TransactionCodeId",
                        column: x => x.TransactionCodeId,
                        principalTable: "TransactionCodes",
                        principalColumn: "TransactionCodeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TransactionDetails_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "TransactionId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BranchId",
                table: "AspNetUsers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountTypeId",
                table: "Accounts",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowerFiles_BorrowerId",
                table: "BorrowerFiles",
                column: "BorrowerId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowerGroups_BorrowerId",
                table: "BorrowerGroups",
                column: "BorrowerId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowerGroups_GroupId",
                table: "BorrowerGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_GenderId",
                table: "Borrowers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_ProvinceId",
                table: "Borrowers",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_StatusId",
                table: "Borrowers",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_TitleId",
                table: "Borrowers",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_TownId",
                table: "Borrowers",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_TownId",
                table: "Branches",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchHolidays_BranchId",
                table: "BranchHolidays",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Collectors_BranchId",
                table: "Collectors",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_GroupLeaderId",
                table: "Groups",
                column: "GroupLeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanProductBranches_BranchId",
                table: "LoanProductBranches",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanProductBranches_LoanProductId",
                table: "LoanProductBranches",
                column: "LoanProductId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanProducts_DisbursementMethodId",
                table: "LoanProducts",
                column: "DisbursementMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanProducts_InterestMethodId",
                table: "LoanProducts",
                column: "InterestMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanProducts_LoanDurationId",
                table: "LoanProducts",
                column: "LoanDurationId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanProducts_LoanInterestPeriodId",
                table: "LoanProducts",
                column: "LoanInterestPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanProducts_RepaymentCycleId",
                table: "LoanProducts",
                column: "RepaymentCycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_DisbursementMethodId",
                table: "Loans",
                column: "DisbursementMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_InterestMethodId",
                table: "Loans",
                column: "InterestMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LoanDurationId",
                table: "Loans",
                column: "LoanDurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LoanProductId",
                table: "Loans",
                column: "LoanProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LoanStatusId",
                table: "Loans",
                column: "LoanStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_RepaymentCycleId",
                table: "Loans",
                column: "RepaymentCycleId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonDetails_CountryId",
                table: "PersonDetails",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonDetails_GenderId",
                table: "PersonDetails",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonDetails_TitleId",
                table: "PersonDetails",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonDetails_TownId",
                table: "PersonDetails",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileModules_MenuId",
                table: "ProfileModules",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileModules_ProfileId",
                table: "ProfileModules",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_CountryId",
                table: "Provinces",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_ProvinceId",
                table: "Towns",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionCodes_CreditAccountId",
                table: "TransactionCodes",
                column: "CreditAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionCodes_DebitAccountId",
                table: "TransactionCodes",
                column: "DebitAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_BranchId",
                table: "TransactionDetails",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_TaxTypeId",
                table: "TransactionDetails",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_TransactionCodeId",
                table: "TransactionDetails",
                column: "TransactionCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_TransactionId",
                table: "TransactionDetails",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BranchId",
                table: "Transactions",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TaxTypeId",
                table: "Transactions",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSessions_UserId1",
                table: "UserSessions",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Branches_BranchId",
                table: "AspNetUsers",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Branches_BranchId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AccountSettings");

            migrationBuilder.DropTable(
                name: "BankBranches");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "BorrowerFiles");

            migrationBuilder.DropTable(
                name: "BorrowerGroups");

            migrationBuilder.DropTable(
                name: "BranchHolidays");

            migrationBuilder.DropTable(
                name: "CollateralTypes");

            migrationBuilder.DropTable(
                name: "Collectors");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Fees");

            migrationBuilder.DropTable(
                name: "GuarantorFiles");

            migrationBuilder.DropTable(
                name: "Guarantors");

            migrationBuilder.DropTable(
                name: "LoanFees");

            migrationBuilder.DropTable(
                name: "LoanFiles");

            migrationBuilder.DropTable(
                name: "loanGuarantors");

            migrationBuilder.DropTable(
                name: "LoanPenalties");

            migrationBuilder.DropTable(
                name: "LoanProductBranches");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "OtherIncomeTypes");

            migrationBuilder.DropTable(
                name: "Penalties");

            migrationBuilder.DropTable(
                name: "PenaltyLoanStatuses");

            migrationBuilder.DropTable(
                name: "PersonDetails");

            migrationBuilder.DropTable(
                name: "ProfileModules");

            migrationBuilder.DropTable(
                name: "RepaymentOrder");

            migrationBuilder.DropTable(
                name: "Sequences");

            migrationBuilder.DropTable(
                name: "StaffDailyReports");

            migrationBuilder.DropTable(
                name: "StaffWeeklyReports");

            migrationBuilder.DropTable(
                name: "TransactionDetails");

            migrationBuilder.DropTable(
                name: "UserSessions");

            migrationBuilder.DropTable(
                name: "WorkingStatuses");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "LoanProducts");

            migrationBuilder.DropTable(
                name: "LoanStatuses");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "TransactionCodes");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Borrowers");

            migrationBuilder.DropTable(
                name: "DisbursementMethod");

            migrationBuilder.DropTable(
                name: "interestMethods");

            migrationBuilder.DropTable(
                name: "LoanDurations");

            migrationBuilder.DropTable(
                name: "loanInterestPeriods");

            migrationBuilder.DropTable(
                name: "RepaymentCycles");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "TaxTypes");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "AccountTypes");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BranchId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
