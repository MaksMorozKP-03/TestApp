using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestApp.Models
{
    class Currency
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("current_price")]
        public decimal Price { get; set; }
        [JsonPropertyName("market_cap_rank")]
        public int Rank { get; set; }
        [JsonPropertyName("image")]
        public string SymbolUrl { get; set; }
        [JsonPropertyName("total_supply")]
        public double? TotalSupply { get; set; }
        [JsonPropertyName("price_change_24h")]
        public decimal DailyPriceChange { get; set; }
        [JsonPropertyName("last_updated")]
        public DateTime LastUpdated { get; set; }   

    }
}
