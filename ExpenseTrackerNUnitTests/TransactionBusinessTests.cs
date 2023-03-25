using NUnit.Framework;
using System;
using System.Collections.Generic;
using Data.Models;
using Business;
using Data;

namespace Tests
{
    public class TransactionBusinessTests
    {
        private TransactionBusiness transactionBusiness;

        [SetUp]
        public void Setup()
        {
            transactionBusiness = new TransactionBusiness();
        }

        [Test]
        public void GetAll_ReturnsListOfTransactions()
        {
            // Arrange

            // Act
            List<Transaction> transactions = transactionBusiness.GetAll();

            // Assert
            Assert.IsInstanceOf(typeof(List<Transaction>), transactions);
        }

        [Test]
        public void Get_WithInvalidId_ReturnsNull()
        {
            // Arrange
            int invalidId = -1;

            // Act
            Transaction actualTransaction = transactionBusiness.Get(invalidId);

            // Assert
            Assert.IsNull(actualTransaction);
        }
        [Test]
        public void Add_AddsTransactionToDatabase()
        {
            // Arrange
            var transaction = new Transaction { Note = "Test Transaction", Amount = 100 };

            // Act
            transactionBusiness.Add(transaction);

            // Assert
            using (var context = new Context())
            {
                var addedTransaction = context.Transactions.FirstOrDefault(t => t.Note == "Test Transaction");
                Assert.IsNotNull(addedTransaction);
                Assert.AreEqual(transaction.Amount, addedTransaction.Amount);
            }
        }
        [Test]
        public void Update_WithInvalidTransaction_ThrowsException()
        {
            // Arrange
            Transaction invalidTransaction = new Transaction
            {
                // create a new transaction object with no corresponding entry in the database
                Id = -1,
                Date = DateTime.Today,
                Note = "Invalid Transaction",
                Amount = 25.00m
            };

            // Act and Assert
            Assert.Throws<Exception>(() => transactionBusiness.Update(invalidTransaction));
        }

        [Test]
        public void Delete_DeletesTransactionFromDatabase()
        {
            // Arrange
            var transaction = new Transaction { Note = "Test Transaction", Amount = 50 };

            // Add transaction to database
            transactionBusiness.Add(transaction);

            // Act
            transactionBusiness.Delete(transaction.Id);

            // Assert
            using (var context = new Context())
            {
                var deletedTransaction = context.Transactions.FirstOrDefault(t => t.Id == transaction.Id);
                Assert.IsNull(deletedTransaction, "Transaction was not deleted from database");
            }
        }
        [Test]
        public void Delete_ThrowsExceptionIfTransactionNotFound()
        {
            // Arrange
            var invalidId = -1;

            // Act & Assert
            Assert.Throws<Exception>(() => transactionBusiness.Delete(invalidId),
                "Delete should throw an exception if transaction is not found in database");

        }

    }
}