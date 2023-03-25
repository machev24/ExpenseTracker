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
        [Test]
        public void TestTransactionAmount()
        {
            var transaction = new Transaction { Amount = 20.5m };
            Assert.AreEqual(20.5m, transaction.Amount);
        }
        [Test]
        public void TestTransactionNote()
        {
            var transaction = new Transaction { Note = "Test note" };
            Assert.AreEqual("Test note", transaction.Note);
        }
    }
}