using Blazor.SEO.Schema;
using Blazor.SEO.Schema.Schema;
using NUnit.Framework;

namespace Tests
{
    public class ItemListTests1
    {
        [SetUp]
        public void Setup()
        {
            var itemList1 = new ItemListModel<string>();
            itemList1.Type = ItemListType.ItemList;
            itemList1.Name = "Top 10 laptops";
            itemList1.ItemListOrder = ItemListModel<string>.ListOrder.Descending;
            itemList1.ItemListElement = new[]
            {
                "HP Pavilion dv6-6013cl",
                "Dell XPS 15 (Sandy Bridge)",
                "Lenovo ThinkPad X220"
            };

            var breadcrumbList = new ItemListModel<ItemListElementModel>();
            breadcrumbList.Type = ItemListModel<ItemListElementModel>.ItemListType.BreadcrumbList;
            breadcrumbList.ItemListElement = new ItemListElementModel[]
            {
                new ItemListElementModel(1, null, "https://example.com/dresses", "Dresses" ),
                new ItemListElementModel(2, null, "https://example.com/dresses/real", "Real Dresses" )
            };

            var advancedItemList1 = new ItemListModel<ItemListElementModel>();

            advancedItemList1.Name = "Top music artists";
            advancedItemList1.Url = "http://en.wikipedia.org/wiki/Billboard_200";
            advancedItemList1.Description = "The artists with the most cumulative weeks at number one according to Billboard 200";
            advancedItemList1.ItemListElement = new[]
            {
                new ItemListElementModel(1, "MusicGroup", null, "Beatles"),
                new ItemListElementModel(2, "MusicGroup", null, "Elvis Presley"),
                new ItemListElementModel(3, "MusicGroup", null, "Michael Jackson")
            };

            var productList = new ItemListModel<ProductModel>();

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}