using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Blazor.SEO.Schema.Schema
{
    public partial class ItemList<T> : BaseModel where T : class
    {
        public ItemList()
        {
            Type = ItemListType.ItemList;
        }

        [JsonProperty("@type")]
        public new ItemListType Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("numberOfItems")]
        public int? NumberOfItems { get; set; }

        [JsonProperty("itemListElement")]
        public T[] ItemListElement { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("itemListOrder")]
        public ListOrder ItemListOrder { get; set; }


        public enum ListOrder
        {
            [EnumMember(Value = "http://schema.org/ItemListOrderAscending")]
            Ascending,
            [EnumMember(Value = "http://schema.org/ItemListOrderDescending")]
            Descending,
            [EnumMember(Value = "http://schema.org/ItemListUnordered")]
            Unordered
        }

        public enum ItemListType
        {
            [EnumMember(Value = "BreadcrumbList")]
            BreadcrumbList,
            [EnumMember(Value = "ItemList")]
            ItemList,
        }

    }


    public class ListItemModel
    {
        [JsonProperty("@type")]
        public string Type { get; private set; } = "ListItem";

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("item")]
        public ItemModel Item { get; set; }

        public ListItemModel()
        {

        }

        public ListItemModel(int position, string type, string id, string name)
        {
            Type = type ?? Type;
            Position = position;

            Item = new ItemModel
            {
                Id = id,
                Name = name
            };
        }

        public class ItemModel
        {
            [JsonProperty("@id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }
}
