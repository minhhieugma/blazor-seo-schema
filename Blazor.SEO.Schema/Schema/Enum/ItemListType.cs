using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Blazor.SEO.Schema.Schema.Enum
{
    public enum ItemListType
    {
        [EnumMember(Value = "BreadcrumbList")]
        BreadcrumbList,

        [EnumMember(Value = "ItemList")]
        ItemList,
    }
}
