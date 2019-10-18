using Blazor.SEO.Schema.Helpers;
using Blazor.SEO.Schema.Schema;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.SEO.Schema.Organization
{
    public class OrganizationModel : BaseModel
    {
        public OrganizationModel()
        {
            this.Type = "Organization";
        }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("contactPoint")]
        public List<ContactPointModel> ContactPoint { get; set; } = new List<ContactPointModel>();

        [JsonProperty("founder")]
        public string Founder { get; set; }

        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("foundingDate")]
        public DateTime FoundingDate { get; set; }

        [JsonProperty("foundingLocation")]
        public string FoundingLocation { get; set; }


        [JsonProperty("knowsLanguage")]
        public string KnowsLanguage { get; set; }

        public class ContactPointModel : BaseModel
        {
            public ContactPointModel()
            {
                this.Type = "ContactPoint";
            }

            [JsonProperty("telephone")]
            public string Telephone { get; set; }

            [JsonProperty("contactType")]
            public string ContactType { get; set; }

            [JsonProperty("contactOption")]
            public string ContactOption { get; set; }

            /// <summary>
            /// US, VN, JP etc
            /// </summary>
            [JsonProperty("areaServed")]
            public string AreaServed { get; set; }

        }

    }
}
