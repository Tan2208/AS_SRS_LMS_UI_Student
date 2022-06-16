using AS_SRS_LMS_UI_Student.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AS_SRS_LMS_UI_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonHocController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public MonHocController(StudentDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<MonHoc>> Get()
            => await _context.MonHocs.ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(MonHoc), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var monhoc = await _context.MonHocs.FindAsync(id);
            return monhoc == null ? NotFound() : Ok(monhoc);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(MonHoc monhoc)
        {
            await _context.MonHocs.AddAsync(monhoc);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = monhoc.MonHocId }, monhoc);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, MonHoc monhoc)
        {
            if (id != monhoc.MonHocId) return BadRequest();
            var mhUpdate = await _context.MonHocs.FindAsync(id);
            if (mhUpdate == null) return NotFound("Không tìm thấy môn học");
            _context.Entry(monhoc).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var monhocToDelete = await _context.MonHocs.FindAsync(id);
            if (monhocToDelete == null) return NotFound("Không tìm thấy môn học");

            _context.MonHocs.Remove(monhocToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
