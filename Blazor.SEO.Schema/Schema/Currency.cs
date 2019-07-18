using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Blazor.SEO.Schema.Schema
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/ISO_4217
    /// </summary>
    public enum Currency
    {
        [EnumMember(Value = "USD")]
        USD = 840,

        [EnumMember(Value = "VND")]
        VND = 704,

        [EnumMember(Value = "JPY")]
        JPY = 392,

        [EnumMember(Value = "CNY")]
        CNY = 156,
        
    }
}
