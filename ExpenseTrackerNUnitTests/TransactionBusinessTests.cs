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
    }
}