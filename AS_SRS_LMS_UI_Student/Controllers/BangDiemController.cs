using AS_SRS_LMS_UI_Student.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AS_SRS_LMS_UI_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BangDiemController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public BangDiemController(StudentDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<BangDiem>> Get()
            => await _context.BangDiems.ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BangDiem), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var bangdiem = await _context.BangDiems.FindAsync(id);
            return bangdiem == null ? NotFound() : Ok(bangdiem);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(BangDiem bangdiem)
        {
            await _context.BangDiems.AddAsync(bangdiem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = bangdiem.BangDiemId }, bangdiem);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, BangDiem bangdiem)
        {
            if (id != bangdiem.BangDiemId) return BadRequest();
            _context.Entry(bangdiem).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var bangdiemToDelete = await _context.BangDiems.FindAsync(id);
            if (bangdiemToDelete == null) return NotFound();

            _context.BangDiems.Remove(bangdiemToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
