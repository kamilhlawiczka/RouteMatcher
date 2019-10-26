using System;

namespace RouteMatcher.Domain
{
    public class Point
    {
        public long UnitId { get; set; }
        public DateTime Timedate { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool Ignition { get; set; }
        public bool Engine { get; set; }
        public float Speed { get; set; }
        public bool PositionError { get; set; }
        public uint Rpm { get; set; }
        public int Direction { get; set; }
        public long Distance { get; set; }
    }
}