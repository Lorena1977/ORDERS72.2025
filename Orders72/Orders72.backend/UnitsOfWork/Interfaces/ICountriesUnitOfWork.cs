using Orders72.Shared.Entities;
using Orders72.Shared.Responses;

namespace Orders72.backend.UnitsOfWork.Interfaces
{
    public interface ICountriesUnitOfWork
    {
        Task<ActionResponse<Country>> GetAsync(int id);

        Task<ActionResponse<IEnumerable<Country>>> GetAsync();
    }

}
