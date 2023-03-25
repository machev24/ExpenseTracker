using Data.Models;
using NUnit.Framework;

namespace Tests
{
    public class TransactionTests
    {
        [Test]
        public void TestTransactionId()
        {
            var transaction = new Transaction { Id = 1 };
            Assert.AreEqual(1, transaction.Id);
        }
        [Test]
        public void TestTransactionCategory()
        {
            var transaction = new Transaction { Category = 2 };
            Assert.AreEqual(2, transaction.Category);
        }


    }
}