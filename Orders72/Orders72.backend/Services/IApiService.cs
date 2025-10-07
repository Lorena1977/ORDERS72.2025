using Orders72.Shared.Responses;

namespace Orders72.backend.Services
{
    public interface IApiService
    {
        Task<ActionResponse<T>> GetAsync<T>(string servicePrefix, string controller);
    }

}
