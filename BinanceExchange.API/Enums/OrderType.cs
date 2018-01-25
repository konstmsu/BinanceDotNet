using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace BinanceExchange.API.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderType
    {
        None,
        [EnumMember(Value = "LIMIT")]
        Limit,
        [EnumMember(Value = "MARKET")]
        Market,
        [EnumMember(Value = "TAKE_PROFIT_LIMIT")]
        TakeProfitLimit,
    }
}
