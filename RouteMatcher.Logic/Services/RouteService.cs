using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using RouteMatcher.Domain;
using RouteMatcher.Infrastructure.DataAccess;
using RouteMatcher.Infrastructure.ExternalApi;
using RouteMatcher.Infrastructure.Services;

namespace RouteMatcher.Services
{
    public class RouteService : IRouteService
    {
        private readonly IRouteRepository routeRepository;
        private readonly IMatchRouteingClient hereClient;

        public RouteService(IRouteRepository routeRepository, IMatchRouteingClient hereClient)
        {
            this.routeRepository = routeRepository;
            this.hereClient = hereClient;
        }

        public IEnumerable<string> List()
        {
            return this.routeRepository.List();
        }

        public async Task<List<Point>> Get(string id)
        {
            return await this.routeRepository.Get(id);
        }

        public async Task<List<Point>> GetRouteMatch(string id)
        {
            var route = await this.routeRepository.Get(id);
            if (route == null)
            {
                return null;
            }

            var result = await this.hereClient.MatchRoute(route);

            for (var idx = 0; idx < result.Length; idx++)
            {
                route[idx].Latitude = result[idx].LatMatched;
                route[idx].Longitude = result[idx].LonMatched;
            }

            return route;
        }
    }
}