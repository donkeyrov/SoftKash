using LoanMgt.SHARED;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanMgt.UI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankBranch> BankBranches { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<BorrowerFile> BorrowerFiles { get; set; }
        public DbSet<BorrowerGroup> BorrowerGroups { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<BranchHoliday> BranchHolidays { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Guarantor> Guarantors { get; set; }
        public DbSet<GuarantorFile> GuarantorFiles { get; set; }
        public DbSet<InterestMethod> interestMethods { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanDuration> LoanDurations { get; set; }
        public DbSet<LoanFee> LoanFees { get; set; }
        public DbSet<LoanFile> LoanFiles { get; set; }
        public DbSet<LoanGuarantor> loanGuarantors { get; set; }
        public DbSet<LoanInterestPeriod> loanInterestPeriods { get; set; }
        public DbSet<LoanPenalty> LoanPenalties { get; set; }
        public DbSet<LoanProduct> LoanProducts { get; set; }
        public DbSet<LoanProductBranch> LoanProductBranches { get; set; }
        public DbSet<LoanStatus> LoanStatuses { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Penalty> Penalties { get; set; }
        public DbSet<PenaltyLoanStatus> PenaltyLoanStatuses { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<RepaymentCycle> RepaymentCycles { get; set; }
        public DbSet<Sequence> Sequences { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<TaxType> TaxTypes { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionCode> TransactionCodes { get; set; }
        public DbSet<TransactionDetails> TransactionDetails { get; set; }
        public DbSet<WorkingStatus> WorkingStatuses { get; set; }
        //public DbSet<Role> Roles{ get; set; }
        //public DbSet<RoleClaim> RoleClaims { get; set; }
        //public DbSet<UserRole> UserRoles { get; set; }
        //public DbSet<User> Users { get; set; }
        public DbSet<UserSession> UserSessions { get; set; }
        public DbSet<PersonDetails> PersonDetails { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<StaffDailyReports> StaffDailyReports { get; set; }
        public DbSet<StaffWeeklyReports> StaffWeeklyReports { get; set; }
        public DbSet<AccountSettings> AccountSettings { get; set; }
        public DbSet<RepaymentOrder> RepaymentOrder { get; set; }
        public DbSet<CollateralType> CollateralTypes { get; set; }
        public DbSet<OtherIncomeType> OtherIncomeTypes { get; set; }
        public DbSet<Collector> Collectors { get; set; }
        public DbSet<AssetManagementType> AssetManagementTypes { get; set; }
        public DbSet<TransactionTemp> TransactionTemps { get; set; }
        public DbSet<Collateral> Collaterals { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<Investor> Investors { get; set; }
        public DbSet<OtherIncome> OtherIncomes { get; set; }
        public DbSet<AttachmentFiles> AttachmentFiles { get; set; }
    }
}
