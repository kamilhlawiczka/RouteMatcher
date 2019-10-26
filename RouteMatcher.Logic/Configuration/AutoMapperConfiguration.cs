using AutoMapper;
using RouteMatcher.Domain;
using RouteMatcher.Dtos;

namespace RouteMatcher.Logic.Configuration
{
    public static class AutoMapperConfiguration
    {
        internal static IMapper Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataAccess.Models.Point, Point>();
                cfg.CreateMap<Point, PointDto>();
            });
            return config.CreateMapper();
        }
    }
}
