using AS_SRS_LMS_UI_Student.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AS_SRS_LMS_UI_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiangVienController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public GiangVienController(StudentDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<GiangVien>> Get()
            => await _context.GiangViens.ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GiangVien), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var giangvien = await _context.GiangViens.FindAsync(id);
            return giangvien == null ? NotFound() : Ok(giangvien);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(GiangVien giangvien)
        {
            await _context.GiangViens.AddAsync(giangvien);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = giangvien.GiangVienId }, giangvien);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, GiangVien giangvien)
        {
            if (id != giangvien.GiangVienId) return BadRequest();
            _context.Entry(giangvien).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var giangvienToDelete = await _context.GiangViens.FindAsync(id);
            if (giangvienToDelete == null) return NotFound();

            _context.GiangViens.Remove(giangvienToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
