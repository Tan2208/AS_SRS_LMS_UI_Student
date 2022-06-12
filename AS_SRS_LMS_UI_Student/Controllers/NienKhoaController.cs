using AS_SRS_LMS_UI_Student.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AS_SRS_LMS_UI_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NienKhoaController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public NienKhoaController(StudentDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<NienKhoa>> Get()
            => await _context.NienKhoas.ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Role), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var nienkhoa = await _context.NienKhoas.FindAsync(id);
            return nienkhoa == null ? NotFound() : Ok(nienkhoa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(NienKhoa nienkhoa)
        {
            await _context.NienKhoas.AddAsync(nienkhoa);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = nienkhoa.NienKhoaId }, nienkhoa);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, NienKhoa nienkhoa)
        {
            if (id != nienkhoa.NienKhoaId) return BadRequest();
            _context.Entry(nienkhoa).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var nienkhoaToDelete = await _context.NienKhoas.FindAsync(id);
            if (nienkhoaToDelete == null) return NotFound();

            _context.NienKhoas.Remove(nienkhoaToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
