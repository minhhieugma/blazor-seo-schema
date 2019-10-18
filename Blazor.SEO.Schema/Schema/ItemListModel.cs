using Blazor.SEO.Schema.Schema;
using Blazor.SEO.Schema.Schema.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace Blazor.SEO.Schema
{
    /// <summary>
    /// ItemListModel
    /// </summary>
    /// <typeparam name="T">ItemListElementModel or string or ThingModel</typeparam>
    public partial class ItemListModel<T> : BaseModel where T : class
    {
        public ItemListModel()
        {
            Type = ItemListType.ItemList;
        }

        [JsonProperty("@type")]
        public new ItemListType Type { get; set; }

        /// <summary>
        /// The number of items in an ItemList. 
        /// Note that some descriptions might not fully describe all items in a list (e.g., multi-page pagination); 
        /// in such cases, the numberOfItems would be for the entire list.
        /// </summary>
        [JsonProperty("numberOfItems")]
        public int? NumberOfItems { get => this.ItemListElement?.Count; }

        /// <summary>
        /// ListItem  or 
        /// Text or Thing
        /// </summary>
        [JsonProperty("itemListElement")]
        public List<T> ItemListElement { get; set; } = new List<T>();

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("itemListOrder")]
        public ListOrder ItemListOrder { get; set; }

    }

    public class ItemListElementModel
    {
        [JsonProperty("@type")]
        public string Type { get; private set; } = "ListItem";

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("item")]
        public ItemModel Item { get; set; }

        public ItemListElementModel()
        {

        }

        public ItemListElementModel(int position, string type, string id, string name)
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

    public class ThingModel
    {
        [JsonProperty("@type")]
        public string Type { get; private set; } = "Thing";

        /// <summary>
        /// The identifier property represents any kind of identifier for any kind of Thing, such as ISBNs, GTIN codes, UUIDs etc. 
        /// Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. 
        /// See background notes for more details.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }


        [JsonProperty("alternateName")]
        public string AlternateName { get; set; }   

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }


        /// <summary>
        /// 	A sub property of description. 
        /// 	A short description of the item used to disambiguate from other, similar items. 
        /// 	Information from other properties (in particular, name) may be necessary for the description to be useful for disambiguation.
        /// </summary>
        [JsonProperty("disambiguatingDescription")]
        public string DisambiguatingDescription { get; set; }
    }
}
