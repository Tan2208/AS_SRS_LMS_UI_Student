using AS_SRS_LMS_UI_Student.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AS_SRS_LMS_UI_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public RoleController(StudentDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Role>> Get()
            => await _context.Roles.ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Role), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var role = await _context.Roles.FindAsync(id);
            return role == null ? NotFound() : Ok(role);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Role role)
        {
            await _context.Roles.AddAsync(role);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = role.RoleId }, role);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, Role role)
        {
            if (id != role.RoleId) return BadRequest();
            _context.Entry(role).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var roleToDelete = await _context.Roles.FindAsync(id);
            if (roleToDelete == null) return NotFound();

            _context.Roles.Remove(roleToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
