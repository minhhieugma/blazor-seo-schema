using Blazor.SEO.Schema.Helpers;
using Blazor.SEO.Schema.Organization;
using Blazor.SEO.Schema.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Blazor.SEO.Schema
{
    public class ProductModel : BaseModel
    {
        public ProductModel()
        {
            this.Type = "Product";
        }

        [JsonProperty("aggregateRating")]
        public AggregateRatingModel AggregateRating { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; } = "0.7 cubic feet countertop microwave. Has six preset cooking categories and convenience features like Add-A-Minute and Child Lock.";

        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// URL of the item.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("image")]
        public List<string> Image { get; set; } = new List<string>();

        /// <summary>
        /// The Stock Keeping Unit (SKU), 
        /// i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        [JsonProperty("sku")]
        public string SKU { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("offers")]
        public OfferModel Offers { get; set; }

        [JsonProperty("review")]
        public List<ReviewModel> Review { get; set; } = new List<ReviewModel>();


        [JsonProperty("productID")]
        public string ProductID { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        [JsonProperty("mpn")]
        public string MPN { get; set; }

        [JsonProperty("owns")]
        public OrganizationModel Owns { get; set; }

        public partial class AggregateRatingModel :  BaseModel
        {
            public AggregateRatingModel()
            {
                this.Type ="AggregateRating";
            }

            [JsonProperty("ratingValue")]
            public decimal RatingValue { get; set; }

            [JsonProperty("reviewCount")]
            public long ReviewCount { get; set; }
        }

        public partial class OfferModel : BaseModel
        {
            /// <summary>
            /// https://schema.org/ItemAvailability
            /// </summary>
            public enum AvailabilityEnum
            {
                [EnumMember(Value = "http://schema.org/InStock")]
                InStock,

                [EnumMember(Value = "http://schema.org/OutOfStock")]
                OutOfStock,

                [EnumMember(Value = "http://schema.org/Discontinued")]
                Discontinued,

                [EnumMember(Value = "http://schema.org/InStoreOnly")]
                InStoreOnly,

                [EnumMember(Value = "http://schema.org/LimitedAvailability")]
                LimitedAvailability,

                [EnumMember(Value = "http://schema.org/OnlineOnly")]
                OnlineOnly,

                [EnumMember(Value = "http://schema.org/PreOrder")]
                PreOrder,

                [EnumMember(Value = "http://schema.org/PreSale")]
                PreSale,

                [EnumMember(Value = "http://schema.org/SoldOut")]
                SoldOut
            }

            public enum ItemConditionEnum
            {
                [EnumMember(Value = "http://schema.org/DamagedCondition")]
                DamagedCondition,

                [EnumMember(Value = "http://schema.org/NewCondition")]
                NewCondition,

                [EnumMember(Value = "http://schema.org/RefurbishedCondition")]
                RefurbishedCondition,

                [EnumMember(Value = "http://schema.org/UsedCondition")]
                UsedCondition
            }


            public OfferModel()
            {
                this.Type = "Offer";
            }

            /// <summary>
            /// URL of the item.
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonConverter(typeof(StringEnumConverter))]
            [JsonProperty("availability")]
            public AvailabilityEnum Availability { get; set; }

            [JsonProperty("price")]
            public decimal Price { get; set; }

            [JsonConverter(typeof(CustomDateTimeConverter))]
            [JsonProperty("priceValidUntil")]
            public DateTime? PriceValidUntil { get; set; }

            [JsonConverter(typeof(StringEnumConverter))]
            [JsonProperty("priceCurrency")]
            public Currency PriceCurrency { get; set; }

            [JsonConverter(typeof(StringEnumConverter))]
            [JsonProperty("@itemCondition")]
            public ItemConditionEnum ItemCondition { get; set; }

        }

        public partial class ReviewModel
        {
            [JsonProperty("@type")]
            public string Type { get; set; } = "Review";

            [JsonProperty("author")]
            public string Author { get; set; } = "Ellie";

            [JsonProperty("datePublished")]
            [JsonConverter(typeof(CustomDateTimeConverter))]
            public DateTime DatePublished { get; set; }// = "2011-04-01";

            [JsonProperty("description")]
            public string Description { get; set; } = "The lamp burned out and now I have to replace it.";

            [JsonProperty("name")]
            public string Name { get; set; } = "Not a happy camper";

            [JsonProperty("reviewRating")]
            public ReviewRating ReviewRating { get; set; }
        }

        public partial class ReviewRating
        {
            [JsonProperty("@type")]
            public string Type { get; set; } = "Rating";

            [JsonProperty("bestRating")]
            public string BestRating { get; set; } = "5";

            [JsonProperty("ratingValue")]
            public string RatingValue { get; set; } = "1";

            [JsonProperty("worstRating")]
            public string WorstRating { get; set; } = "1";
        }
    }
}
