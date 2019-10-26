using System.Collections.Generic;
using System.Threading.Tasks;
using RouteMatcher.Domain;
using RouteMatcher.Infrastructure.ExternalApi.ResponseModels;

namespace RouteMatcher.Infrastructure.ExternalApi
{
    public interface IMatchRouteingClient
    {
        Task<ITracePoint[]> MatchRoute(List<Point> route);
    }
}