using System;
using System.Text.Json.Serialization;

namespace TestApp.Models
{
    public class Currency
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("current_price")]
        public decimal Price { get; set; }
        [JsonPropertyName("market_cap_rank")]
        public int Rank { get; set; }
        [JsonPropertyName("total_volume")]
        public decimal Volume { get; set; }
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
