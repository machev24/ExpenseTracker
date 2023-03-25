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
        [Test]
        public void CategoryIconShouldBeSettableAndGettable()
        {
            // Arrange
            var category = new Category();
            var expectedIcon = "fa fa-car";

            // Act
            category.Icon = expectedIcon;

            // Assert
            Assert.AreEqual(expectedIcon, category.Icon);
        }
        [Test]
        public void CategoryTypeShouldBeSettableAndGettable()
        {
            // Arrange
            var category = new Category();
            var expectedType = "expense";

            // Act
            category.Type = expectedType;

            // Assert
            Assert.AreEqual(expectedType, category.Type);
        }
    }
}

       