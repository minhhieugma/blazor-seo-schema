using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.SEO.Schema.Schema
{
    public class BaseModel
    {
        [JsonProperty("@context")]
        public string Context { get; set; } = @"http://schema.org";

        [JsonProperty("@type")]
        public string Type { get; set; } = "ItemList";
    }
}
