using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WS_VINOTRIP.Models.EntityFramework;

namespace WS_VINOTRIP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VignoblesController : ControllerBase
    {
        private readonly VinotripDBContext _context;

        public VignoblesController(VinotripDBContext context)
        {
            _context = context;
        }

        // GET: api/Vignobles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vignoble>>> GetRoutesDesVins()
        {
            return await _context.Vignobles.ToListAsync();
        }

        // GET: api/Vignobles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vignoble>> GetVignobles(int id)
        {
            var vignoble = await _context.Vignobles.FindAsync(id);

            if (vignoble == null)
            {
                return NotFound();
            }

            return vignoble;
        }

        // PUT: api/Vignobles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVignobles(int id, Vignoble vignoble)
        {
            if (id != vignoble.VignobleId)
            {
                return BadRequest();
            }

            _context.Entry(vignoble).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VignoblesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vignobles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vignoble>> PostVignobles(Vignoble vignoble)
        {
            _context.Vignobles.Add(vignoble);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVignobles", new { id = vignoble.VignobleId }, vignoble);
        }

        // DELETE: api/Vignobles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVignobles(int id)
        {
            var vignoble = await _context.Vignobles.FindAsync(id);
            if (vignoble == null)
            {
                return NotFound();
            }

            _context.Vignobles.Remove(vignoble);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VignoblesExists(int id)
        {
            return _context.Vignobles.Any(e => e.VignobleId == id);
        }
    }
}
