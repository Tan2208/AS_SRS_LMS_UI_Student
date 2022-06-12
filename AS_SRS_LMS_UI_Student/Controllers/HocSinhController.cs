using AS_SRS_LMS_UI_Student.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AS_SRS_LMS_UI_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocSinhController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public HocSinhController(StudentDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<HocSinh>> Get()
            => await _context.HocSinhs.ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(HocSinh), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var hocsinh = await _context.HocSinhs.FindAsync(id);
            return hocsinh == null ? NotFound() : Ok(hocsinh);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(HocSinh hocsinh)
        {
            await _context.HocSinhs.AddAsync(hocsinh);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = hocsinh.HocSinhId }, hocsinh);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, HocSinh hocsinh)
        {
            if (id != hocsinh.HocSinhId) return BadRequest();
            _context.Entry(hocsinh).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var hocsinhToDelete = await _context.HocSinhs.FindAsync(id);
            if (hocsinhToDelete == null) return NotFound();

            _context.HocSinhs.Remove(hocsinhToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
