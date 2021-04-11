using System.Net.Http;
using CustomerSite.Interfaces;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System;
using CustomerSite.Exceptions;
using System.Net.Http.Headers;

namespace CustomerSite.Services
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

            try
            {
                var resp = await _host.GetAsync(route + routeParams);
                if (!resp.IsSuccessStatusCode)
                    return default(T);
                // throw new Exception(resp.StatusCode.ToString());
                return await resp.Content.ReadFromJsonAsync<T>();
            }
            catch (Exception)
            {
                throw new ServeNotAvaiableException();
            }
        }
        public async Task<(T, HttpResponseHeaders)> GetWithRespAsync<T>(string route, string routeParams = "")
        {
            try
            {
                var resp = await _host.GetAsync(route + routeParams);
                if (!resp.IsSuccessStatusCode)
                    return (default(T), null);
                // throw new Exception(resp.StatusCode.ToString());
                return (await resp.Content.ReadFromJsonAsync<T>(), resp.Headers);
            }
            catch (Exception)
            {
                throw new ServeNotAvaiableException();
            }
        }

        public async Task<T> PostAsync<T>(string route, object bodyContent, string routeParams = "")
        {
            try
            {
                var resp = await _host.PostAsJsonAsync(route + routeParams, bodyContent);
                if (!resp.IsSuccessStatusCode)
                    throw new Exception(resp.StatusCode.ToString());
                return await resp.Content.ReadFromJsonAsync<T>();
            }
            catch (Exception)
            {
                throw new ServeNotAvaiableException();
            }

        }

        public async Task<bool> PutAsync(string route, object bodyContent, string routeParams = "")
        {
            try
            {
                var resp = await _host.PutAsJsonAsync(route + routeParams, bodyContent);
                if (!resp.IsSuccessStatusCode)
                    throw new Exception(resp.StatusCode.ToString());
                return true;
            }
            catch (Exception)
            {
                throw new ServeNotAvaiableException();
            }
        }

        public async Task<bool> DeleteAsync(string route, string routeParams = "")
        {
            try
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
            catch (Exception)
            {
                throw new ServeNotAvaiableException();
            }


        }
    }
}