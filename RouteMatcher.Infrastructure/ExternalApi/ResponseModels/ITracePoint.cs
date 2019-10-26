namespace RouteMatcher.Infrastructure.ExternalApi.ResponseModels
{
    public interface ITracePoint
    {
        double LatMatched { get; set; }
        double LonMatched { get; set; }
    }
}