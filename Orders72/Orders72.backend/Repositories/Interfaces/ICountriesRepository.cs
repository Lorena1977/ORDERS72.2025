using Orders72.Shared.DTOs;
using Orders72.Shared.Entities;
using Orders72.Shared.Responses;

namespace Orders72.backend.Repositories.Interfaces
{
    public interface ICountriesRepository
    {
        Task<ActionResponse<Country>> GetAsync(int id); //Sobreescribimos el metodo get

        Task<ActionResponse<IEnumerable<Country>>> GetAsync(); //Sobreescribimos el getAsync que me devuelve la lista de paises (para 
        //que me traiga los paises y los estados)
        Task<ActionResponse<IEnumerable<Country>>> GetAsync(PaginationDTO pagination);
        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
        Task<IEnumerable<Country>> GetComboAsync();
    }

}
