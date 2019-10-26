using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RouteMatcher.Domain;
using RouteMatcher.HereComClient.ResponseModels;
using RouteMatcher.Infrastructure.ExternalApi;
using RouteMatcher.Infrastructure.ExternalApi.ResponseModels;

namespace RouteMatcher.HereComClient
{
    public class ApiClient : IMatchRouteingClient
    {
        private readonly HttpClient client;
        private readonly IConfiguration configuration;
        private readonly string appId;
        private readonly string appCode;

        public ApiClient(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.appId = configuration["ApiHereCom:AppId"];
            this.appCode = configuration["ApiHereCom:AppCode"];
            this.client = new HttpClient();
            this.client.BaseAddress = new Uri("https://rme.api.here.com");
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // curl -H "Content-Type: application/binary" -XPOST 'https://rme.api.here.com/2/matchroute.json?app_id=e5gvSoPfmn9H05Dy4Cnb&app_code=jqO2Ny2-V-ecje26PvOF5A&routemode=car&filetype=GPX' -d "@/tmp/input.gpx" | json_pp
        public async Task<ITracePoint[]> MatchRoute(List<Point> route)
        {
            var queryParams = new Dictionary<string, string>()
            {
                { "app_id", this.appId },
                { "app_code", this.appCode },
                { "filetype", "CSV" }
            };
            var path = QueryHelpers.AddQueryString("/2/matchroute.json", queryParams);

            var body = new StringContent(Converter.PointsToCsv(route));
            body.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await this.client.PostAsync(path, body);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<MatchRouteResponse>(content).TracePoints;
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new ClientException(errorMessage);
            }
        }
    }
}
