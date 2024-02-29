using Api.DAL;
using Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly AppDbContext _db;
        public TagController(AppDbContext db)
        {                            
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int page = 1, int take = 3)
        {
            List<Tag> tags = await _db.Tags.Skip((page - 1) * take).Take(take).ToListAsync();
            return Ok(tags);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0) return StatusCode(StatusCodes.Status400BadRequest);

            Tag tag = await _db.Tags.FirstOrDefaultAsync(t => t.Id == id);

            if (tag is null) return StatusCode(StatusCodes.Status404NotFound);

            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Tag tag)
        {
            await _db.Tags.AddAsync(tag);
            await _db.SaveChangesAsync();

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, string name)
        {
            if (id <= 0) return StatusCode(StatusCodes.Status400BadRequest);
            Tag existed = await _db.Tags.FirstOrDefaultAsync(t => t.Id == id);
            if (existed is null) return StatusCode(StatusCodes.Status404NotFound);

            existed.Name = name;
            await _db.SaveChangesAsync();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return StatusCode(StatusCodes.Status400BadRequest);

            Tag existed = await _db.Tags.FirstOrDefaultAsync(t => t.Id == id);

            if (existed is null) return StatusCode(StatusCodes.Status404NotFound);

            _db.Tags.Remove(existed);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
