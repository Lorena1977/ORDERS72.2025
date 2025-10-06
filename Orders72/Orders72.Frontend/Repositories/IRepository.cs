namespace Orders72.Frontend.Repositories
{
    //Agregamos 3 métodos GetAsync, PostAsync.
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> GetAsync<T>(string url);

        Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T model);//Post que no devuelve respuesta

        Task<HttpResponseWrapper<TActionResponse>> PostAsync<T, TActionResponse>(string url, T model);//Post que devuelve respuesta
    }

}
