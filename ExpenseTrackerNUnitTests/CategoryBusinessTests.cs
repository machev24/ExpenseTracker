using NUnit.Framework;
using Business;
using Data.Models;

namespace Business.Tests
{
    [TestFixture]
    public class CategoryBusinessTests
    {
        [Test]
        public void GetAll_ShouldReturnAllCategories()
        {
            // Arrange
            var categoryBusiness = new CategoryBusiness();

            // Act
            var result = categoryBusiness.GetAll();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

        [Test]
        public void Get_ShouldReturnSingleCategory()
        {
            // Arrange
            var categoryBusiness = new CategoryBusiness();

            // Act
            var result = categoryBusiness.Get(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Id);
        }

        [Test]
        public void Add_ShouldAddCategory()
        {
            // Arrange
            var categoryBusiness = new CategoryBusiness();
            var category = new Category { Title = "Test Category" };

            // Act
            categoryBusiness.Add(category);

            // Assert
            var result = categoryBusiness.Get(category.Id);
            Assert.IsNotNull(result);
            Assert.AreEqual(category.Title, result.Title);
        }

        [Test]
        public void Update_ShouldUpdateCategory()
        {
            // Arrange
            var categoryBusiness = new CategoryBusiness();
            var category = new Category { Id = 1, Title = "Updated Category" };

            // Act
            categoryBusiness.Update(category);

            // Assert
            var result = categoryBusiness.Get(category.Id);
            Assert.IsNotNull(result);
            Assert.AreEqual(category.Title, result.Title);
        }

        [Test]
        public void Update_ShouldThrowExceptionIfEntryNotFound()
        {
            // Arrange
            var categoryBusiness = new CategoryBusiness();
            var category = new Category { Id = 1000, Title = "Updated Category" };

            // Act & Assert
            Assert.Throws<System.Exception>(() => categoryBusiness.Update(category));
        }

        [Test]
        public void Delete_ShouldDeleteCategory()
        {
            // Arrange
            var categoryBusiness = new CategoryBusiness();
            var category = new Category { Icon = "Test Category" };
            categoryBusiness.Add(category);

            // Act
            categoryBusiness.Delete(category.Id);

            // Assert
            var result = categoryBusiness.Get(category.Id);
            Assert.IsNull(result);
        }

        [Test]
        public void Delete_ShouldThrowExceptionIfEntryNotFound()
        {
            // Arrange
            var categoryBusiness = new CategoryBusiness();

            // Act & Assert
            Assert.Throws<System.Exception>(() => categoryBusiness.Delete(1000));
        }
    }
}