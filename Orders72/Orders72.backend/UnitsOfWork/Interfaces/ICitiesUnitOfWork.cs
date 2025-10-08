using Orders72.Shared.DTOs;
using Orders72.Shared.Entities;
using Orders72.Shared.Responses;

namespace Orders72.backend.UnitsOfWork.Interfaces
{
    public interface ICitiesUnitOfWork
    {
        Task<ActionResponse<IEnumerable<City>>> GetAsync(PaginationDTO pagination);

        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
        Task<IEnumerable<City>> GetComboAsync(int stateId);
    }

}
