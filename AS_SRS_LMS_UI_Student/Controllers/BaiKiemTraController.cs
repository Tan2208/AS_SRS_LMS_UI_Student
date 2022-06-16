using AS_SRS_LMS_UI_Student.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AS_SRS_LMS_UI_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaiKiemTraController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public BaiKiemTraController(StudentDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<BaiKiemTra>> Get()
            => await _context.BaiKiemTras.ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaiKiemTra), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var baikt = await _context.BaiKiemTras.FindAsync(id);
            return baikt == null ? NotFound() : Ok(baikt);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(BaiKiemTra baikt)
        {

            await _context.BaiKiemTras.AddAsync(baikt);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = baikt.BaiKiemTraId }, baikt);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, BaiKiemTra baikt)
        {
            if (id != baikt.BaiKiemTraId) return BadRequest();
            var bktUpdate = await _context.BaiKiemTras.FindAsync(id);
            if (bktUpdate == null) return NotFound("Không tìm thấy bài kiểm tra");
            _context.Entry(baikt).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var baiktToDelete = await _context.BaiKiemTras.FindAsync(id);
            if (baiktToDelete == null) return NotFound("Không tìm thấy bài kiểm tra");

            _context.BaiKiemTras.Remove(baiktToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
