using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RouteMatcher.Dtos;
using RouteMatcher.Infrastructure.Services;

namespace RouteMatcher.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        private readonly IRouteService routeService;

        public RoutesController(IRouteService routeService)
        {
            this.routeService = routeService;
        }

        // GET api/routes
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(this.routeService.List().ToList());
        }

        // GET api/routes/123
        [HttpGet("{id}")]
        public async Task<ActionResult<List<PointDto>>> Get(string id)
        {
            var route = await this.routeService.Get(id);
            if (route != null)
            {
                return Ok(route);
            }

            return NotFound();
        }

        // GET api/routes/123/routematch
        [HttpGet("{id}/routematch")]
        public async Task<ActionResult<List<PointDto>>> GetRouteMatch(string id)
        {
            var route = await this.routeService.GetRouteMatch(id);
            if (route != null)
            {
                return Ok(route);
            }

            return NotFound();
        }
    }
}