using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orders72.backend.Data;
using Orders72.Shared.Entities;

namespace Orders72.backend.Controllers
{

    [ApiController] //DataAnotation para decirle a la clase que es un controller.
    [Route("api/[controller]")] //Para rutear el controlador, esto es como lo voy a llamar en el Swagger.
    public class CountriesController : ControllerBase //El controlador tiene que heredar del ControllerBase
    {
        private readonly DataContext _context;

        public CountriesController(DataContext context)
        {
            _context = context;
        }

        //Metodo para obtener paises
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Countries.ToListAsync());
        }

        //Mètodo para obtener paises por Id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            return Ok(country);
        }

        //Método para crear paises
        [HttpPost]
        public async Task<IActionResult> PostAsync(Country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();
            return Ok(country);
        }

        //Método para borrar paises por ID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            _context.Remove(country);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        //Método para modificar paises.
        [HttpPut]
        public async Task<IActionResult> PutAsync(Country country)
        {
            _context.Update(country);
            await _context.SaveChangesAsync();//Metodo que guarda los cambios
            return Ok(country);
        }
    }
}

