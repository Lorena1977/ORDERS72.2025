using Orders72.Shared.DTOs;
using Orders72.Shared.Entities;
using Orders72.Shared.Responses;

namespace Orders72.backend.Repositories.Interfaces
{
    public interface ICitiesRepository
    {
        Task<ActionResponse<IEnumerable<City>>> GetAsync(PaginationDTO pagination);

        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
    }
}
