using System.Collections.Generic;
using System.Threading.Tasks;
using RouteMatcher.Domain;

namespace RouteMatcher.Infrastructure.DataAccess
{
    public interface IRouteRepository
    {
        IEnumerable<string> List();
        Task<List<Point>> Get(string id);
    }
}