using Blazor.SEO.Schema.Helpers;
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
    public class ApartmentModel : BaseModel
    {
        public ApartmentModel()
        {
            this.Type = "Apartment";
        }

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business. 
        /// Typical unit code(s): ROM for room or C62 for no unit. 
        /// The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [JsonProperty("numberOfRooms")]
        public int NumberOfRooms { get; set; }

        /// <summary>
        /// The allowed total occupancy for the accommodation in persons (including infants etc).
        /// For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement 
        /// (e.g. a double room used by a single person). Typical unit code(s): C62 for person
        /// </summary>
        [JsonProperty("occupancy")]
        public string Occupancy { get; set; }

    }

   
}
