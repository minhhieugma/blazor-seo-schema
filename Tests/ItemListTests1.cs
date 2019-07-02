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
            var itemList1 = new ItemList<string>();
            itemList1.Type = ItemList<string>.ItemListType.ItemList;
            itemList1.Name = "Top 10 laptops";
            itemList1.ItemListOrder = ItemList<string>.ListOrder.Descending;
            itemList1.ItemListElement = new[]
            {
                "HP Pavilion dv6-6013cl",
                "Dell XPS 15 (Sandy Bridge)",
                "Lenovo ThinkPad X220"
            };

            var breadcrumbList = new ItemList<ListItemModel>();
            breadcrumbList.Type = ItemList<ListItemModel>.ItemListType.BreadcrumbList;
            breadcrumbList.ItemListElement = new ListItemModel[]
            {
                new ListItemModel(1, null, "https://example.com/dresses", "Dresses" ),
                new ListItemModel(2, null, "https://example.com/dresses/real", "Real Dresses" )
            };

            var advancedItemList1 = new ItemList<ListItemModel>();

            advancedItemList1.Name = "Top music artists";
            advancedItemList1.Url = "http://en.wikipedia.org/wiki/Billboard_200";
            advancedItemList1.Description = "The artists with the most cumulative weeks at number one according to Billboard 200";
            advancedItemList1.ItemListElement = new[]
            {
                new ListItemModel(1, "MusicGroup", null, "Beatles"),
                new ListItemModel(2, "MusicGroup", null, "Elvis Presley"),
                new ListItemModel(3, "MusicGroup", null, "Michael Jackson")
            };

            var productList = new ItemList<Product>();

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}