using Orders72.backend.Repositories.Interfaces;
using Orders72.backend.UnitsOfWork.Interfaces;
using Orders72.Shared.DTOs;
using Orders72.Shared.Entities;
using Orders72.Shared.Responses;

namespace Orders72.backend.UnitsOfWork.Implementations
{
    public class CategoriesUnitOfWork : GenericUnitOfWork<Category>, ICategoriesUnitOfWork
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesUnitOfWork(IGenericRepository<Category> repository, ICategoriesRepository categoriesRepository) : base(repository)
        {
            _categoriesRepository = categoriesRepository;
        }

        public override async Task<ActionResponse<IEnumerable<Category>>> GetAsync(PaginationDTO pagination) => await _categoriesRepository.GetAsync(pagination);

        public override async Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination) => await _categoriesRepository.GetTotalPagesAsync(pagination);
        public async Task<IEnumerable<Category>> GetComboAsync() => await _categoriesRepository.GetComboAsync();
    }

}
