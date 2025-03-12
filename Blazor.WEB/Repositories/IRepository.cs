namespace Blazor.WEB.Repositories
{
    public interface IRepository
    {
        Task<HttpResponserWrapper<T>> Get<T>(string url); //--https://localhost:7022--/

        Task<HttpResponserWrapper<object>> Post<T>(string url, T model);

        Task<HttpResponserWrapper<TResponse>> Post<T, TResponse>(string url, T model);
    }
}
