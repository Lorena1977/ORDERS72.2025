using Orders72.backend.Repositories.Interfaces;
using Orders72.backend.UnitsOfWork.Interfaces;
using Orders72.Shared.DTOs;
using Orders72.Shared.Entities;
using Orders72.Shared.Responses;

namespace Orders72.backend.UnitsOfWork.Implementations
{
    public class CitiesUnitOfWork : GenericUnitOfWork<City>, ICitiesUnitOfWork
    {
        private readonly ICitiesRepository _citiesRepository;

        public CitiesUnitOfWork(IGenericRepository<City> repository, ICitiesRepository citiesRepository) : base(repository)
        {
            _citiesRepository = citiesRepository;
        }

        public override async Task<ActionResponse<IEnumerable<City>>> GetAsync(PaginationDTO pagination) => await _citiesRepository.GetAsync(pagination);

        public override async Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination) => await _citiesRepository.GetTotalPagesAsync(pagination);
        public async Task<IEnumerable<City>> GetComboAsync(int stateId) => await _citiesRepository.GetComboAsync(stateId);


    }

}
