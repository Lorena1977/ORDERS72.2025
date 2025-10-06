namespace Orders72.Frontend.Repositories
{
    //Agregamos 3 métodos GetAsync, PostAsync.
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> GetAsync<T>(string url);

        Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T model);//Post que no devuelve respuesta

        Task<HttpResponseWrapper<TActionResponse>> PostAsync<T, TActionResponse>(string url, T model);//Post que devuelve respuesta

        Task<HttpResponseWrapper<object>> DeleteAsync(string url);

        Task<HttpResponseWrapper<object>> PutAsync<T>(string url, T model);

        Task<HttpResponseWrapper<TActionResponse>> PutAsync<T, TActionResponse>(string url, T model);//Sobrecargamos el put par que nos pueda devolver una respuesta
    }

}
