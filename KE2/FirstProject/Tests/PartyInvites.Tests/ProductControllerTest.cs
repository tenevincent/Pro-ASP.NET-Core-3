using Microsoft.AspNetCore.Mvc;
using Moq;
using PartyInvites.Business;
using PartyInvites.Business.Repositories;
using PartyInvites.Controllers;
using System;
using System.Collections.Generic;
using Xunit;

namespace PartyInvites.Tests
{
    public class ProductControllerTest
    {

        [Fact]
        public void IndexActionModelIsComplete()
        {

            // Arrange
            Product[] testData = new Product[] {
                new Product { Name = "P1", Price = 75.10M },
                new Product { Name = "P2", Price = 120M },
                new Product { Name = "P3", Price = 110M }
            };
            var mock = new Mock<IDataSource>();
            mock.SetupGet(m => m.Products).Returns(testData);
            var controller = new ProductController();
            controller.DataSource = mock.Object;

            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;

            // Assert
            Assert.Equal(testData, model,
                Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name
                    && p1.Price == p2.Price));

            mock.VerifyGet(m => m.Products, Times.Once);
        }



    }
}
