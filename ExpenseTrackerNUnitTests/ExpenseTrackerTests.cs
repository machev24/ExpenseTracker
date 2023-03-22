using Data;
using Data.Models;
using Moq;
using NUnit.Framework;
using System;

namespace Business.Tests
{
    [TestFixture]
    public class CategoryBusinessTests
    {
        private CategoryBusiness categoryBusiness;

        [SetUp]
        public void SetUp()
        {
            categoryBusiness = new CategoryBusiness();
        }


        [Test]
        public void Get_WithInvalidId_ReturnsNull()
        {
            var category = categoryBusiness.Get(-1);

            Assert.IsNull(category);
        }
    }
}


      
        

