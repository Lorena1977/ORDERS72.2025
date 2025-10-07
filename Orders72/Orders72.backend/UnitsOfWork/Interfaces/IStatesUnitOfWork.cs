using Orders72.Shared.Entities;
using Orders72.Shared.Responses;

namespace Orders72.backend.UnitsOfWork.Interfaces
{
    public interface IStatesUnitOfWork
    {
        Task<ActionResponse<State>> GetAsync(int id);

        Task<ActionResponse<IEnumerable<State>>> GetAsync();
    }

}
