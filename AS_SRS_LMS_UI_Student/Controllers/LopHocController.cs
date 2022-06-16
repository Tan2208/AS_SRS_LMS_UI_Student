using AS_SRS_LMS_UI_Student.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AS_SRS_LMS_UI_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LopHocController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public LopHocController(StudentDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<LopHoc>> Get()
            => await _context.LopHocs.ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(LopHoc), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var lophoc = await _context.LopHocs.FindAsync(id);
            return lophoc == null ? NotFound() : Ok(lophoc);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(LopHoc lophoc)
        {
            await _context.LopHocs.AddAsync(lophoc);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = lophoc.LopHocId }, lophoc);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, LopHoc lophoc)
        {
            if (id != lophoc.LopHocId) return BadRequest();
            var lhUpdate = await _context.LopHocs.FindAsync(id);
            if (lhUpdate == null) return NotFound("Không tìm thấy lớp học");
            _context.Entry(lophoc).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var lophocToDelete = await _context.LopHocs.FindAsync(id);
            if (lophocToDelete == null) return NotFound("Không tìm thấy lớp học");

            _context.LopHocs.Remove(lophocToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
