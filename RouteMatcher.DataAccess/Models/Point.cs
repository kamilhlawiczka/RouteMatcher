using System;
using Newtonsoft.Json;

namespace RouteMatcher.DataAccess.Models
{
    public class Point
    {
        [JsonProperty("unitId")]
        public long UnitId { get; set; }

        [JsonProperty("timedate")]
        public DateTime Timedate { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("ignition")]
        public bool Ignition { get; set; }

        [JsonProperty("engine")]
        public bool Engine { get; set; }

        [JsonProperty("speed")]
        public float Speed { get; set; }

        [JsonProperty("positionError")]
        public bool PositionError { get; set; }

        [JsonProperty("rpm")]
        public uint Rpm { get; set; }

        [JsonProperty("direction")]
        public int Direction { get; set; }

        [JsonProperty("distance")]
        public long Distance { get; set; }
    }
}