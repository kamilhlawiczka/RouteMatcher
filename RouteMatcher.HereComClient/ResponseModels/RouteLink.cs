using Newtonsoft.Json;

namespace RouteMatcher.HereComClient.ResponseModels
{
    public class RouteLink
    {
        [JsonProperty("linkId")]
        public long LinkId { get; set; }

        [JsonProperty("functionalClass")]
        public long FunctionalClass { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("shape")]
        public string Shape { get; set; }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public double? Offset { get; set; }

        [JsonProperty("mSecToReachLinkFromStart")]
        public long MSecToReachLinkFromStart { get; set; }

        [JsonProperty("linkLength")]
        public double LinkLength { get; set; }
    }
}