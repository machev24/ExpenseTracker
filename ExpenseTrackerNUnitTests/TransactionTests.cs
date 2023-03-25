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

    }
}