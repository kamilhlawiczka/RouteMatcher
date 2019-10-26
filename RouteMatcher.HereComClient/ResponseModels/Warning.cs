using Newtonsoft.Json;

namespace RouteMatcher.HereComClient.ResponseModels
{
    public class Warning
    {
        [JsonProperty("category")]
        public long Category { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("routeLinkSeqNum")]
        public long RouteLinkSeqNum { get; set; }

        [JsonProperty("tracePointSeqNum")]
        public long TracePointSeqNum { get; set; }

        [JsonProperty("breakDuration", NullValueHandling = NullValueHandling.Ignore)]
        public long? BreakDuration { get; set; }

        [JsonProperty("toTracePointSeqNum", NullValueHandling = NullValueHandling.Ignore)]
        public long? ToTracePointSeqNum { get; set; }
    }
}
