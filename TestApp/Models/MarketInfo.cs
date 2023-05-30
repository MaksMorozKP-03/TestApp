using System.Text.Json.Serialization;

namespace TestApp.Models
{
    public class MarketInfo
    {
        [JsonPropertyName("baseId")]
        public string CurrencyId { get; set; }
        [JsonPropertyName("exchangeId")]
        public string MarketName { get; set; }
        [JsonPropertyName("priceUsd")]
        public decimal Price { get; set; }
        
        public override string ToString()
        {
            return $"You can by this currency for {Price} USD at {MarketName}";
        }
    }
}
