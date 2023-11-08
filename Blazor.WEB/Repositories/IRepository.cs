using Web.Repositories;

namespace Blazor.WEB.Repositories
{
    public interface IRepository
    {
        //get
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        //post
        Task<HttpResponseWrapper<object>> Post<T>(string url, T model);
        //post que devuelve respuesta
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T model);
        //delete
        Task<HttpResponseWrapper<object>> Delete(string url);
        //put
        Task<HttpResponseWrapper<object>> Put<T>(string url, T model);
        //put que devuelve respuesta
        Task<HttpResponseWrapper<TResponse>> Put<T, TResponse>(string url, T model);
    }
}
