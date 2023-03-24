using Business;
using Data.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class CategoryBusinessTests
    {
        private CategoryBusiness categoryBusiness;

        [SetUp]
        public void Setup()
        {
            categoryBusiness = new CategoryBusiness();
        }

        [Test]
        public void GetAllReturnsAllCategories()
        {
            // Arrange
            var expectedCategories = new List<Category>
            {
                new Category { Id = 1, Title = "TestCategory1" },
                new Category { Id = 2, Title = "TestCategory2" },
                new Category { Id = 3, Title = "TestCategory3" }
            };
            foreach (var category in expectedCategories)
            {
                categoryBusiness.Add(category);
            }

            // Act
            var result = categoryBusiness.GetAll();

            // Assert
            CollectionAssert.AreEqual(expectedCategories, result);
        }

        [Test]
        public void GetReturnsCategoryWithGivenId()
        {
            // Arrange
            int id = 1;
            var expectedCategory = new Category { Id = id, Title = "TestCategory" };
            categoryBusiness.Add(expectedCategory);

            // Act
            var result = categoryBusiness.Get(id);

            // Assert
            Assert.AreEqual(expectedCategory, result);
        }

        [Test]
        public void AddInsertsCategoryIntoDatabase()
        {
            // Arrange
            var newCategory = new Category { Title = "TestCategory" };

            // Act
            categoryBusiness.Add(newCategory);

            // Assert
            var result = categoryBusiness.Get(newCategory.Id);
            Assert.AreEqual(newCategory, result);
        }

        [Test]
        public void UpdateUpdatesExistingCategory()
        {
            // Arrange
            var categoryToUpdate = new Category { Title = "TestCategory" };
            categoryBusiness.Add(categoryToUpdate);

            var updatedCategory = new Category { Id = categoryToUpdate.Id, Title = "TestCategoryUpdated" };

            // Act
            categoryBusiness.Update(updatedCategory);

            // Assert
            var result = categoryBusiness.Get(categoryToUpdate.Id);
            Assert.AreEqual(updatedCategory, result);
        }

        [Test]
        public void UpdateThrowsExceptionWhenEntryNotFound()
        {
            // Arrange
            var categoryToUpdate = new Category { Id = 1, Title = "TestCategory" };

            // Act and Assert
            Assert.Throws<Exception>(() => categoryBusiness.Update(categoryToUpdate));
        }

        [Test]
        public void DeleteRemovesCategoryFromDatabase()
        {
            // Arrange
            var categoryToDelete = new Category { Title = "TestCategory" };
            categoryBusiness.Add(categoryToDelete);

            // Act
            categoryBusiness.Delete(categoryToDelete.Id);

            // Assert
            var result = categoryBusiness.Get(categoryToDelete.Id);
            Assert.IsNull(result);
        }

        [Test]
        public void DeleteThrowsExceptionWhenEntryNotFound()
        {
            // Arrange
            int nonExistingCategoryId = 1;

            // Act and Assert
            Assert.Throws<Exception>(() => categoryBusiness.Delete(nonExistingCategoryId));
        }
    }
}


