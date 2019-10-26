using Newtonsoft.Json;

namespace RouteMatcher.HereComClient.ResponseModels
{
    public class MatchRouteResponse
    {
        [JsonProperty("RouteLinks")]
        public RouteLink[] RouteLinks { get; set; }

        [JsonProperty("TracePoints")]
        public TracePoint[] TracePoints { get; set; }

        [JsonProperty("Warnings")]
        public Warning[] Warnings { get; set; }

        [JsonProperty("MapVersion")]
        public string MapVersion { get; set; }
    }
}