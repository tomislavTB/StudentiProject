using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentiProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace StudentiProject.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly DB.StudentiProjectContext _context;

        public CityController(DB.StudentiProjectContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> GetCityItem()
        {
            return await _context.Cities.ToListAsync();
        }


        // GET
        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCityItem(int id)
        {
            var CityItem = await _context.Cities.FindAsync(id);

            if (CityItem == null)
            {
                return NotFound();
            }

            return CityItem;
        }

        // POST
        [HttpPost]
        public async Task<IActionResult> PostCityItem(City item)
        {
            if (!ModelState.IsValid)

            {
                return ValidationProblem(ModelState);
            }
            _context.Cities.Add(item);
            await _context.SaveChangesAsync();
            return StatusCode(201);
        }

        // PUT: api/Todo/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutCityItem(int Id, [FromBody] City item)
        {
            item.Id = Id;

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteCity(int Id)
        {
            var CityItem = await _context.Cities.FindAsync(Id);

            if (CityItem == null)
            {
                return NotFound();
            }

            _context.Cities.Remove(CityItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}