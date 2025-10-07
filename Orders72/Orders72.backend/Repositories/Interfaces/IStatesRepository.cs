using Orders72.Shared.Entities;
using Orders72.Shared.Responses;

namespace Orders72.backend.Repositories.Interfaces
{
    public interface IStatesRepository
    {
        Task<ActionResponse<State>> GetAsync(int id);

        Task<ActionResponse<IEnumerable<State>>> GetAsync();
    }

}
