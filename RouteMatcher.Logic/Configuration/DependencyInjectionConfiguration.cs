using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RouteMatcher.DataAccess.Repositories;
using RouteMatcher.HereComClient;
using RouteMatcher.Infrastructure.DataAccess;
using RouteMatcher.Infrastructure.ExternalApi;
using RouteMatcher.Infrastructure.Services;
using RouteMatcher.Services;

namespace RouteMatcher.Logic.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddSingleton<IRouteRepository, RouteRepository>();
            services.AddSingleton<IRouteService, RouteService>();
            services.AddSingleton<IMatchRouteingClient, ApiClient>();
            services.AddSingleton<IMapper>(p => AutoMapperConfiguration.Configure());
        }
    }
}
