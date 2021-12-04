using LoanMgt.UI.Data;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace LoanMgt.TEST
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "sofkash")
                .Options;

            var context = new ApplicationDbContext(options);
            //var query = new geta
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}