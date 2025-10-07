using Microsoft.AspNetCore.Mvc;
using Orders72.backend.UnitsOfWork.Interfaces;
using Orders72.Shared.Entities;

namespace Orders72.backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : GenericController<City>
    {
        public CitiesController(IGenericUnitOfWork<City> unitOfWork) : base(unitOfWork)
        {
        }
    }

}
