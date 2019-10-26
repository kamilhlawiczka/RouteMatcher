using Newtonsoft.Json;
using RouteMatcher.Infrastructure.ExternalApi.ResponseModels;

namespace RouteMatcher.HereComClient.ResponseModels
{
    public class TracePoint : ITracePoint
    {
        [JsonProperty("breakDetected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BreakDetected { get; set; }

        [JsonProperty("breakDuration", NullValueHandling = NullValueHandling.Ignore)]
        public long? BreakDuration { get; set; }

        [JsonProperty("calculatedAccel")]
        public long CalculatedAccel { get; set; }

        [JsonProperty("confidenceValue")]
        public double ConfidenceValue { get; set; }

        [JsonProperty("elevation")]
        public long Elevation { get; set; }

        [JsonProperty("headingDegreeNorthClockwise")]
        public long HeadingDegreeNorthClockwise { get; set; }

        [JsonProperty("headingMatched")]
        public long HeadingMatched { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("latMatched")]
        public double LatMatched { get; set; }

        [JsonProperty("linkIdMatched")]
        public long LinkIdMatched { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lonMatched")]
        public double LonMatched { get; set; }

        [JsonProperty("matchDistance")]
        public double MatchDistance { get; set; }

        [JsonProperty("matchOffsetOnLink")]
        public double MatchOffsetOnLink { get; set; }

        [JsonProperty("minError")]
        public long MinError { get; set; }

        [JsonProperty("routeLinkSeqNrMatched")]
        public long RouteLinkSeqNrMatched { get; set; }

        [JsonProperty("speedMps")]
        public long SpeedMps { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("accelerationMPSS", NullValueHandling = NullValueHandling.Ignore)]
        public double? AccelerationMpss { get; set; }
    }
}