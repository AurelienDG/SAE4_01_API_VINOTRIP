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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SejoursController : ControllerBase
    {
        private readonly IDataRepository<Sejour> dataRepository;
        private readonly IDataRepository<CatParticipant> dataRepository2;
        private readonly IDataRepository<Comporte> dataRepository3;
        public SejoursController(IDataRepository<Sejour> dataRepo, IDataRepository<CatParticipant> dataRepo2, IDataRepository<Comporte> dataRepo3)
        {
            dataRepository = dataRepo;
            dataRepository2 = dataRepo2;
            dataRepository3 = dataRepo3;
        }

        // GET: api/Sejours
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sejour>>> GetSejours()
        {
            return dataRepository.GetAllAsync().Result;
        }

        // GET: api/Sejours/5
        [HttpGet]
        [Route("[action]/{id}")]
        [ActionName("GetById")]
        public async Task<ActionResult<Sejour>> GetSejourById(int id)
        {
            var sejour = dataRepository.GetByIdAsync(id).Result;

            if (sejour == null)
            {
                return NotFound();
            }

            return sejour;
        }

        //idcatvignoble idcatsejour, idcatparticipant
        [HttpGet]
        [Route("[action]/{catsejour}/{catvignoble}/{catparticipant}")]
        [ActionName("GetWithFilter")]
        public async Task<ActionResult<IEnumerable<Sejour>>> GetSejourFilter(int catsejour, int catvignoble, int catparticipant)
        {
            if (catsejour == null && catvignoble == null && catparticipant == null)
                return dataRepository.GetAllAsync().Result;

            var pute = dataRepository3.GetAllAsync().Result.Value.Where(e => e.CatParticipantId == catparticipant);

            var filterList = dataRepository.GetAllAsync().Result.Value.Where(e => e.CatSejourId == catsejour && e.CatVignobleId == catvignoble);

            foreach (var sejour in filterList)
            {
                var result = sejour.ComporteSejour.Intersect(pute);
            }

            //var utilisateur = await _context.Utilisateurs.FirstOrDefaultAsync(e => e.Mail.ToUpper() == email.ToUpper());

            if (filterList == null)
            {
                return NotFound();
            }

            return filterList.ToList();
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
