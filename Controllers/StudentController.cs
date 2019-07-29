using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentiProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace StudentiProject.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DB.StudentiProjectContext _context;

        public StudentController(DB.StudentiProjectContext context)
        {
            _context = context;

            if (_context.Students.Count() < 2)
            {

                _context.Students.Add(new Student { FirstName = "Tomislav ", LastName = "Buhovac", CityId = 1, DivisionId = 1 });
                _context.Students.Add(new Student { FirstName = "Marko ", LastName = "Markic", CityId = 2, DivisionId = 2 });
                _context.SaveChanges();
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudentItem()
        {
            return await _context.Students.ToListAsync();
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentItem(int id)
        {
            var StudentItem = await _context.Students.FindAsync(id);

            if (StudentItem == null)
            {
                return NotFound();
            }

            return StudentItem;
        }
        [HttpPost]
        public async Task<IActionResult> PostStudentItem(Student item)
        {

            if (!ModelState.IsValid)

            {
                return ValidationProblem(ModelState);
            }
            _context.Students.Add(item);
            await _context.SaveChangesAsync();
            return StatusCode(201);
        }

        // PUT: api/Todo/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutStudentItem(int Id, [FromBody] Student item)
        {
            item.Id = Id;

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var Student = await _context.Students.FindAsync(id);

            if (Student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(Student);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}