using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentiProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace StudentiProject.Controllers
{
    [Route("api/colleges")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        private readonly DB.StudentiProjectContext _context;

        public CollegeController(DB.StudentiProjectContext context)
        {
            _context = context;

            
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<College>>> GetCollegeItem()
        {
            return await _context.Colleges.ToListAsync();
        }


        // GET

        [HttpGet("{id}")]
        public async Task<ActionResult<College>> GetCollegeItem(int id)
        {
            var CollegeItem = await _context.Colleges.FindAsync(id);

            if (CollegeItem == null)
            {
                return NotFound();
            }

            return CollegeItem;
        }

        //POST

        [HttpPost]
        public async Task<IActionResult> PostCollegeItem(College item)
        {
            if (!ModelState.IsValid)

            {
                return ValidationProblem(ModelState);
            }
            _context.Colleges.Add(item);
            await _context.SaveChangesAsync();
            return StatusCode(201);
        }

        // PUT: api/Todo/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutCollegeItem(int Id, [FromBody] College item)
        {
            item.Id = Id;

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteCollegek(int id)
        {
            var College = await _context.Colleges.FindAsync(id);

            if (College == null)
            {
                return NotFound();
            }

            _context.Colleges.Remove(College);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}