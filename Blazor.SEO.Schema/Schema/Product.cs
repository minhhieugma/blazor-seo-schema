using Blazor.SEO.Schema.Helpers;
using Blazor.SEO.Schema.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.SEO.Schema
{
    public class Product : BaseModel
    {
        public Product()
        {
            this.Type = "Product";
        }

        [JsonProperty("aggregateRating")]
        public AggregateRatingModel AggregateRating { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; } = "0.7 cubic feet countertop microwave. Has six preset cooking categories and convenience features like Add-A-Minute and Child Lock.";

        [JsonProperty("name")]
        public string Name { get; set; } = "Kenmore White 17\" Microwave";

        [JsonProperty("image")]
        public string Image { get; set; } = "kenmore-microwave-17in.jpg";

        [JsonProperty("offers")]
        public OfferModel Offers { get; set; }

        [JsonProperty("review")]
        public ReviewModel[] Review { get; set; }

        public partial class AggregateRatingModel
        {
            [JsonProperty("@type")]
            public string Type { get; set; } = "AggregateRating";

            [JsonProperty("ratingValue")]
            public string RatingValue { get; set; } // "3.5",

            [JsonProperty("reviewCount")]
            public long ReviewCount { get; set; } // "11"
        }

        public partial class OfferModel
        {
            [JsonProperty("@type")]
            public string Type { get; set; } = "Offer";

            [JsonProperty("availability")]
            public string Availability { get; set; } = "http://schema.org/InStock";

            [JsonProperty("price")]
            public string Price { get; set; } = "55.00";

            [JsonProperty("priceCurrency")]
            public string PriceCurrency { get; set; } = "USD";
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
