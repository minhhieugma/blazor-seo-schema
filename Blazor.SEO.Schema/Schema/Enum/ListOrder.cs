using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Blazor.SEO.Schema.Schema.Enum
{
    public enum ListOrder
    {
        [EnumMember(Value = "http://schema.org/ItemListOrderAscending")]
        Ascending,

        [EnumMember(Value = "http://schema.org/ItemListOrderDescending")]
        Descending,

        [EnumMember(Value = "http://schema.org/ItemListUnordered")]
        Unordered
    }
}
