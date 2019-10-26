using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Newtonsoft.Json;
using RouteMatcher.Domain;
using RouteMatcher.Infrastructure.DataAccess;

namespace RouteMatcher.DataAccess.Repositories
{
    public class RouteRepository : IRouteRepository
    {
        private readonly IMapper mapper;
        private readonly string location;
        public RouteRepository(IMapper mapper)
        {
            this.mapper = mapper;
            this.location = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"Data");
        }

        public IEnumerable<string> List()
        {
            foreach (var file in Directory.GetFiles(this.location))
            {
                if (Path.GetExtension(file).ToLower() == ".json")
                {
                    yield return Path.GetFileNameWithoutExtension(file);
                }
            }
        }

        public async Task<List<Point>> Get(string id)
        {
            try
            {
                var path = Path.Combine(this.location, id + ".json");
                var data = File.ReadAllTextAsync(path);
                var route = JsonConvert.DeserializeObject<List<Models.Point>>(await data);
                return this.mapper.Map<List<Models.Point>, List<Point>>(route);
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }
    }
}