using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WS_VINOTRIP.Models.EntityFramework;
using WS_VINOTRIP.Models.Repository;

namespace WS_VINOTRIP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SejoursController : ControllerBase
    {
        private readonly IDataRepository<Sejour> dataRepository;
        public SejoursController(IDataRepository<Sejour> dataRepo)
        {
            dataRepository = dataRepo;
        }

        // GET: api/Sejours
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sejour>>> GetSejours()
        {
            return dataRepository.GetAllAsync().Result;
        }

        // GET: api/Sejours/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sejour>> GetSejourById(int id)
        {
            var sejour = dataRepository.GetByIdAsync(id).Result;

            if (sejour == null)
            {
                return NotFound();
            }

            return sejour;
        }

        public async Task<ActionResult<Sejour>> GetSejourByTitre(string titre)
        {
            var sejour = dataRepository.GetByStringAsync(titre);
            //var utilisateur = await _context.Utilisateurs.FirstOrDefaultAsync(e => e.Mail.ToUpper() == email.ToUpper());

            if (sejour.Result == null)
            {
                return NotFound();
            }

            return sejour.Result;
        }

        // PUT: api/Sejours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSejour(int id, Sejour sejour)
        {
            if (id != sejour.SejourId)
            {
                return BadRequest();
            }

            var sejourToUpdate = dataRepository.GetByIdAsync(id);

            if (sejourToUpdate == null)
            {
                return NotFound();
            }

            else
            {
                dataRepository.UpdateAsync(sejourToUpdate.Result.Value, sejour);
                return NoContent();
            }
        }

        // POST: api/Sejours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sejour>> PostSejour(Sejour sejour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            dataRepository.AddAsync(sejour);

            return CreatedAtAction("GetById", new { id = sejour.SejourId }, sejour); // GetById : nom de l’action
        }

        // DELETE: api/Sejours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSejour(int id)
        {
            var sejour = dataRepository.GetByIdAsync(id);

            if (sejour == null)
            {
                return NotFound();
            }

            dataRepository.DeleteAsync(sejour.Result.Value);

            return NoContent();
        }

        /*private bool SejourExists(int id)
        {
            return _context.Sejours.Any(e => e.SejourId == id);
        }*/
    }
}
