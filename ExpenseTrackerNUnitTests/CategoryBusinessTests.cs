using NUnit.Framework;
using System;
using System.Collections.Generic;
using Data.Models;
using Business;
using Data;

namespace Tests
{
    public class CategoryBusinessTests
    {
        private CategoryBusiness categoryBusiness;

        [SetUp]
        public void Setup()
        {
           categoryBusiness = new CategoryBusiness();
        }

      
        [Test]
        public void GetWithInvalidId_ReturnsNull()
        {
            // Arrange
            int invalidId = -1;

            // Act
            Category actualCategory = categoryBusiness.Get(invalidId);

            // Assert
            Assert.IsNull(actualCategory);
        }
        
        [Test]
        public void DeleteThrowsExceptionIfTransactionNotFound()
        {
            // Arrange
            var invalidId = -1;

            // Act & Assert
            Assert.Throws<Exception>(() => categoryBusiness.Delete(invalidId),
                "Delete should throw an exception if transaction is not found in database");

        }

    }
}