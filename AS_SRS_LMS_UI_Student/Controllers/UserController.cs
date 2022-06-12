using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AS_SRS_LMS_UI_Student.Models;
using Microsoft.EntityFrameworkCore;

namespace AS_SRS_LMS_UI_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public UserController(StudentDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
            => await _context.Users.ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user == null ? NotFound() : Ok(user);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new {id=user.UserId}, user);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, User user)
        {
            if(id != user.UserId) return BadRequest();
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var userToDelete = await _context.Users.FindAsync(id);
            if (userToDelete == null) return NotFound();

            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        
    }
}
