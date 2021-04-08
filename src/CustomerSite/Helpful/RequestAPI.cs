using System.Net.Http;
using CustomerSite.Interfaces;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System;

namespace CustomerSite.Helpful
{
    public class RequestAPI : IRequestAPI
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private HttpClient _host;

        public RequestAPI(IHttpClientFactory httpClient)
        {
            _httpClientFactory = httpClient;
            _host = _httpClientFactory.CreateClient("host");
        }

        public async Task<T> GetAsync<T>(string route, string routeParams = "")
        {
            var resp = await _host.GetAsync(route + routeParams);
            if (!resp.IsSuccessStatusCode)
                throw new Exception(resp.StatusCode.ToString());
            return await resp.Content.ReadFromJsonAsync<T>();
        }

        public async Task<T> PostAsync<T>(string route, object bodyContent, string routeParams = "")
        {
            var resp = await _host.PostAsJsonAsync(route + routeParams, bodyContent);
            if (!resp.IsSuccessStatusCode)
                throw new Exception(resp.StatusCode.ToString());
            return await resp.Content.ReadFromJsonAsync<T>();
        }

        public async Task<bool> PutAsync(string route, object bodyContent, string routeParams = "")
        {
            var resp = await _host.PutAsJsonAsync(route + routeParams, bodyContent);
            if (!resp.IsSuccessStatusCode)
                throw new Exception(resp.StatusCode.ToString());
            return true;
        }

        public async Task<bool> DeleteAsync(string route, string routeParams = "")
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(Startup.HostUri + route + routeParams)
            };
            var resp = await _host.SendAsync(request);
            if (!resp.IsSuccessStatusCode)
                throw new Exception(resp.StatusCode.ToString());
            return true;
        }
    }
}