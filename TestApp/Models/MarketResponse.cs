using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace TestApp.Models
{
    public class MarketResponse
    {
        [JsonPropertyName("data")]
        public ObservableCollection<MarketInfo> Data { get; set; }
        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }
    }
}
