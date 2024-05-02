using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Streaming.Model
{
    public class MarketData
    {
        [JsonProperty("Mid_Open")]
        public double? MidOpen { get; set; }

        public double? High { get; set; }
        public double? Low { get; set; }
        public double? Change { get; set; }

        [JsonProperty("Change_Pct")]
        public double? ChangePct { get; set; }

        [JsonProperty("Update_Time")]
        public string UpdateTime { get; set; }

        [JsonProperty("Market_Delay")]
        public int? MarketDelay { get; set; }

        [JsonProperty("Market_State")]
        public string MarketState { get; set; }

        public double Bid { get; set; }
        public double Offer { get; set; }
        public string Epic { get; set; }
    }
}