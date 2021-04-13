using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CustomerSite.Interfaces
{
    public interface IRequestAPI
    {
        Task<T> GetAsync<T>(string route, string routeParams = "");
        Task<T> PostAsync<T>(string route, object bodyContent, string routeParams = "");
        Task<bool> PutAsync(string route, object bodyContent, string routeParams = "");
        Task<bool> DeleteAsync(string route, string routeParams = "");
        Task<(T Data, HttpResponseHeaders Header)> GetWithRespAsync<T>(string route, string routeParams = "");
    }
}