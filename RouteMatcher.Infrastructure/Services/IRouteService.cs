using System.Collections.Generic;
using System.Threading.Tasks;
using RouteMatcher.Domain;

namespace RouteMatcher.Infrastructure.Services
{
    public interface IRouteService
    {
        IEnumerable<string> List();
        Task<List<Point>> Get(string id);
        Task<List<Point>> GetRouteMatch(string id);
    }
}
