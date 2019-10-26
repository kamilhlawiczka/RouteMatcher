using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using RouteMatcher.Domain;

namespace RouteMatcher.HereComClient
{
    public static class Converter
    {
        public static string PointsToCsv(List<Point> route)
        {
            var csv = new StringBuilder();
            csv.AppendLine("latitude,longitude,timestamp,heading");
            foreach (var point in route)
            {
                csv.AppendFormat(
                    "{0},{1},{2},{3}{4}",
                    point.Latitude.ToString(CultureInfo.InvariantCulture),
                    point.Longitude.ToString(CultureInfo.InvariantCulture),
                    point.Timedate.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                    point.Direction,
                    Environment.NewLine);
            }

            return csv.ToString();
        }
    }
}
