using Blazor.SEO.Schema.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.SEO.Schema.Schema
{
    public class AccommodationModel : BaseModel
    {
        public AccommodationModel()
        {
            this.Type = "Accommodation";
        }

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. 
        /// This generic property does not make a statement 
        /// about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// LocationFeatureSpecification
        /// </summary>
        [JsonProperty("amenityFeature")]
        public LocationFeatureSpecification AmenityFeature { get; set; }

        /// <summary>
        /// The size of the accommodation, e.g. in square meter or squarefoot. 
        /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard
        /// QuantitativeValue 
        /// </summary>
        [JsonProperty("floorSize")]
        public string FloorSize { get; set; }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business. 
        /// Typical unit code(s): ROM for room or C62 for no unit. 
        /// The type of room can be put in the unitText property of the QuantitativeValue.
        /// Number  or QuantitativeValue 
        /// </summary>
        [JsonProperty("numberOfRooms")]
        public int NumberOfRooms { get; set; }

        /// <summary>
        /// Indications regarding the permitted usage of the accommodation.
        /// </summary>
        [JsonProperty("permittedUsage")]
        public string PermittedUsage { get; set; }

        /// <summary>
        /// Indicates whether pets are allowed to enter the accommodation or lodging business. 
        /// More detailed information can be put in a text value.
        /// Boolean  or Text
        /// </summary>
        [JsonProperty("petsAllowed")]
        public bool PetsAllowed { get; set; }

        public class LocationFeatureSpecification
        {
            /// <summary>
            /// The hours during which this service or contact is available.
            /// https://schema.org/OpeningHoursSpecification
            /// </summary>
            [JsonProperty("hoursAvailable")]
            public string HoursAvailable { get; set; }

            /// <summary>
            /// The date when the item becomes valid.
            /// Date  or DateTime
            /// </summary>
            [JsonConverter(typeof(CustomDateTimeConverter))]
            [JsonProperty("validFrom")]
            public DateTime ValidFrom { get; set; }

            /// <summary>
            /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
            /// Date  or DateTime
            /// </summary>
            [JsonConverter(typeof(CustomDateTimeConverter))]
            [JsonProperty("validThrough")]
            public DateTime ValidThrough { get; set; }
        }
    }
}
