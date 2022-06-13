using AS_SRS_LMS_UI_Student.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AS_SRS_LMS_UI_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LichThiController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public LichThiController(StudentDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<LichThi>> Get()
            => await _context.LichThis.ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(LichThi), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var lichthi = await _context.LichThis.FindAsync(id);
            return lichthi == null ? NotFound() : Ok(lichthi);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(LichThi lichthi)
        {
            await _context.LichThis.AddAsync(lichthi);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = lichthi.LichThiId }, lichthi);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, LichThi lichthi)
        {
            if (id != lichthi.LichThiId) return BadRequest();
            _context.Entry(lichthi).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var lichthiToDelete = await _context.LichThis.FindAsync(id);
            if (lichthiToDelete == null) return NotFound();

            _context.LichThis.Remove(lichthiToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
