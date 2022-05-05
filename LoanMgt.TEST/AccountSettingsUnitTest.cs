using LoanMgt.UI.Data;
using LoanMgt.UI.Repositories;
using LoanMgt.SHARED;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace LoanMgt.TEST
{
    public class AccountSettingsUnitTest
    {
        private ApplicationDbContext _context;
        private AccountSettingsRepository _repository;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "sofkash")
                .Options;

            _context = new ApplicationDbContext(options);
            _context.Database.EnsureCreated();

            _repository = new AccountSettingsRepository(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
        }

        [Test]
        public void AccountSettings_Add_EnsureAccountSettingsCreated()
        {
            AccountSettings accountSettings = new AccountSettings()
            {
                AccountSettingsId = 0,
                CompanyName = "Netzach Systems",
                //CountryId = 1,
                //CurrencyId = 1,
                //DateFormat =   "DD-MM-yyyy",
                //DaysInMonthInterestCalculation = 30,
                //MonthlyLoanRepaymentCycle = 30,
                
            };

            _repository.Add(accountSettings);
            int accountID = accountSettings.AccountSettingsId;
            var newAccount = _repository.Get(accountID);

            Assert.That(accountID, Is.GreaterThan(0));
            Assert.That(accountSettings.CompanyName, Is.EqualTo(newAccount.CompanyName));
        }

        [Test]
        public void AccountSettings_Update_EnsureAccountSettingsUpdated()
        {
            AccountSettings accountSettings = new AccountSettings()
            {
                AccountSettingsId = 0,
                CompanyName = "Netzach Systems",
                //CountryId = 1,
                //CurrencyId = 1,
                //DateFormat = "DD-MM-yyyy",
                //DaysInMonthInterestCalculation = 30,
                //MonthlyLoanRepaymentCycle = 30,

            };

            _repository.Add(accountSettings);
            int accountID = accountSettings.AccountSettingsId;
            var newAccount = _repository.Get(accountID);
            
            Assert.That(accountID, Is.GreaterThan(0));
            Assert.That(accountSettings.CompanyName, Is.EqualTo(newAccount.CompanyName));

            newAccount.CompanyName = "Netzach";
           //newAccount.CurrencyId = 2;
            _repository.Update(newAccount);

            var myAccount = _repository.Get(accountID);

            //Assert.That(myAccount.CurrencyId, Is.EqualTo(2));
            Assert.That(newAccount.CompanyName, Is.EqualTo(myAccount.CompanyName));
        }
    }
}
