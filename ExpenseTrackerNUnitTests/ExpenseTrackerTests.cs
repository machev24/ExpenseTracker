using NUnit.Framework;
using Data.Models;
using Business;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ExpenseTrackerNUnitTests
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
        public void GetAll_ReturnsAllTransactions()
        {
            //Arrange
            var expectedCount = 3;

            //Act
            var result = transactionBusiness.GetAll();

            //Assert
            Assert.IsNotNull(result);

            Assert.AreEqual(expectedCount, result.Count);
        }

        [Test]
        public void Get_ReturnsTransaction()
        {
            //Arrange
            var expectedTransaction = new Transaction()
            {
                id = 1,
                date = new DateTime(2021, 06, 01),
                amount = 50,
                category = 1,
                note = "Transaction 1"
            };

            //Act
            var result = transactionBusiness.Get(1);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedTransaction.id, result.id);
            Assert.AreEqual(expectedTransaction.date, result.date);
            Assert.AreEqual(expectedTransaction.amount, result.amount);
            Assert.AreEqual(expectedTransaction.category, result.category);
            Assert.AreEqual(expectedTransaction.note, result.note);
        }

        [Test]
        public void Add_AddsTransaction()
        {
            //Arrange
            var transaction = new Transaction()
            {
                date = new DateTime(2021, 06, 02),
                amount = 100,
                category = 2,
                note = "Transaction 4"
            };

            //Act
            transactionBusiness.Add(transaction);

            var result = transactionBusiness.Get(4);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(transaction.date, result.date);
            Assert.AreEqual(transaction.amount, result.amount);
            Assert.AreEqual(transaction.category, result.category);
            Assert.AreEqual(transaction.note, result.note);
        }

        [Test]
        public void Update_UpdatesTransaction()
        {
            //Arrange
            var transaction = new Transaction()
            {
                id = 2,
                date = new DateTime(2021, 06, 03),
                amount = 75,
                category = 3,
                note = "Updated Transaction 2"
            };

            //Act
            transactionBusiness.Update(transaction);

            var result = transactionBusiness.Get(2);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(transaction.id, result.id);
            Assert.AreEqual(transaction.date, result.date);
            Assert.AreEqual(transaction.amount, result.amount);
            Assert.AreEqual(transaction.category, result.category);
            Assert.AreEqual(transaction.note, result.note);
        }

        [Test]
        public void Delete_DeletesTransaction()
        {
            //Arrange
            var transactionCountBeforeDelete = transactionBusiness.GetAll().Count;

            //Act
            transactionBusiness.Delete(2);

            var result = transactionBusiness.GetAll();
            var transactionCountAfterDelete = result.Count;
            var deletedTransaction = result.FirstOrDefault(x => x.id == 2);

            //Assert
            Assert.IsNotNull(deletedTransaction);
            Assert.That(transactionCountAfterDelete, Is.EqualTo(transactionCountBeforeDelete - 1));
        }
    }
}



