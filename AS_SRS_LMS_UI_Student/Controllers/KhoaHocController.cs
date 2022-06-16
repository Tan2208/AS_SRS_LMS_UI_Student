using AS_SRS_LMS_UI_Student.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AS_SRS_LMS_UI_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoaHocController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public KhoaHocController(StudentDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<KhoaHoc>> Get()
            => await _context.KhoaHocs.ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(KhoaHoc), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var khoahoc = await _context.KhoaHocs.FindAsync(id);
            return khoahoc == null ? NotFound() : Ok(khoahoc);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(KhoaHoc khoahoc)
        {
            await _context.KhoaHocs.AddAsync(khoahoc);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = khoahoc.KhoaHocId }, khoahoc);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, KhoaHoc khoahoc)
        {
            if (id != khoahoc.KhoaHocId) return BadRequest();
            var khUpdate = await _context.KhoaHocs.FindAsync(id);
            if (khUpdate == null) return NotFound("Không tìm thấy khoá học");
            _context.Entry(khoahoc).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var khoahocToDelete = await _context.KhoaHocs.FindAsync(id);
            if (khoahocToDelete == null) return NotFound("Không tìm thấy khoá học");

            _context.KhoaHocs.Remove(khoahocToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
