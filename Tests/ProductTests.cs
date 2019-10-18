
using Blazor.SEO.Schema;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class ProductTests
    {
        [SetUp]
        public void Setup()
        {

            var product = new Product();
            product.Description = "0.7 cubic feet countertop microwave. Has six preset cooking categories and convenience features like Add-A-Minute and Child Lock.";

            product.Name = "Kenmore White 17\" Microwave";
            product.Image = new List<string> { "kenmore-microwave-17in.jpg" };

            product.Review = new List<Product.ReviewModel> { new Product.ReviewModel
            {
                Author = "Ellie",
                Description = "The lamp burned out and now I have to replace it.",
                Name = "Not a happy camper",

            } };
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}