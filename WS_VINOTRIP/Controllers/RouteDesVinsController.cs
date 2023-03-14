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
    public class RouteDesVinsController : ControllerBase
    {
        private readonly VinotripDBContext _context;

        public RouteDesVinsController(VinotripDBContext context)
        {
            _context = context;
        }

        // GET: api/RouteDesVins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RouteDesVins>>> GetRouteDesVinss()
        {
            return await _context.RouteDesVinss.ToListAsync();
        }

        // GET: api/RouteDesVins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RouteDesVins>> GetRouteDesVins(int id)
        {
            var routeDesVins = await _context.RouteDesVinss.FindAsync(id);

            if (routeDesVins == null)
            {
                return NotFound();
            }

            return routeDesVins;
        }

        // PUT: api/RouteDesVins/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRouteDesVins(int id, RouteDesVins routeDesVins)
        {
            if (id != routeDesVins.RouteDesVinsId)
            {
                return BadRequest();
            }

            _context.Entry(routeDesVins).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RouteDesVinsExists(id))
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

        // POST: api/RouteDesVins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RouteDesVins>> PostRouteDesVins(RouteDesVins routeDesVins)
        {
            _context.RouteDesVinss.Add(routeDesVins);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRouteDesVins", new { id = routeDesVins.RouteDesVinsId }, routeDesVins);
        }

        // DELETE: api/RouteDesVins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRouteDesVins(int id)
        {
            var routeDesVins = await _context.RouteDesVinss.FindAsync(id);
            if (routeDesVins == null)
            {
                return NotFound();
            }

            _context.RouteDesVinss.Remove(routeDesVins);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RouteDesVinsExists(int id)
        {
            return _context.RouteDesVinss.Any(e => e.RouteDesVinsId == id);
        }
    }
}
