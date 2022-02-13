using LoanMgt.UI.Data;
using LoanMgt.UI.Repositories;
using LoanMgt.SHARED;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace LoanMgt.TEST
{
    public class AccountTests
    {
        private ApplicationDbContext _context;
        private AccountRepository _repository;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "sofkash")
                .Options;

            _context = new ApplicationDbContext(options);
            _context.Database.EnsureCreated();
            
            _repository = new AccountRepository(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
        }

        [Test]
        public void Account_Add_EnsureAccountCreated()
        {
            Account account = new Account()
            {
                AccountId = 0,
                AccountName = "Income",
                Code =  "11001",
                AccountTypeId = 1,
                CurrencyId = 1,
                Active = true,  
                Debit = 0,
                Credit = 0
            };

            _repository.Add(account);
            int accountID = account.AccountId;
            var newAccount = _repository.Get(accountID);

            Assert.That(accountID,Is.GreaterThan(0) );
            Assert.That(account.Code, Is.EqualTo(newAccount.Code));
        }

        [Test]
        public void Account_Update_EnsureAccountUpdated()
        {
            Account account = new Account()
            {
                AccountId = 0,
                AccountName = "Income",
                Code = "11001",
                AccountTypeId = 1,
                CurrencyId = 1,
                Active = true,
                Debit = 0,
                Credit = 0
            };

            _repository.Add(account);
            int accountID = account.AccountId;
            var newAccount = _repository.Get(accountID);

            Assert.That(accountID, Is.GreaterThan(0));
            Assert.That(newAccount.Debit, Is.EqualTo(0));
            Assert.That(account.Code, Is.EqualTo(newAccount.Code));

            newAccount.Debit = 5000;
            newAccount.AccountName = "Capital";
            _repository.Update(newAccount);

            var myAccount = _repository.Get(accountID);

            Assert.That(myAccount.Debit, Is.EqualTo(5000));
            Assert.That(newAccount.AccountName, Is.EqualTo(myAccount.AccountName));
        }
    }
}