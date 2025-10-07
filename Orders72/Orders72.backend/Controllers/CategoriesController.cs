using Microsoft.AspNetCore.Mvc;
using Orders72.backend.UnitsOfWork.Interfaces;
using Orders72.Shared.Entities;

namespace Orders72.backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : GenericController<Category>
    {
        public CategoriesController(IGenericUnitOfWork<Category> unit) : base(unit)
        {
        }
    }

}
