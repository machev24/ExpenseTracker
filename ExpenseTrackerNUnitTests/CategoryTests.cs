using Data.Models;
using NUnit.Framework;
using System.ComponentModel.DataAnnotations;

namespace Data.Tests.Models
{
    public class CategoryTests
    {
        [Test]
        public void Category_Id_Should_Have_KeyAttribute()
        {
            // Arrange
            var category = new Category();

            // Act
            var idProperty = category.GetType().GetProperty("Id");

            // Assert
            Assert.That(Attribute.IsDefined(idProperty, typeof(KeyAttribute)));
        }
        [Test]
        public void CategoryTitleShouldBeSettableAndGettable()
        {
            // Arrange
            var category = new Category();
            var expectedTitle = "Test Category";

            // Act
            category.Title = expectedTitle;

            // Assert
            Assert.AreEqual(expectedTitle, category.Title);
        }
    }
}

       