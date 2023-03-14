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
    public class AvisController : ControllerBase
    {
        private readonly IDataRepository<Avis> dataRepository;

        public AvisController(IDataRepository<Avis> dataRepo)
        {
            dataRepository = dataRepo;
        }


        // GET: api/Avis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Avis>>> GetAvis()
        {
            return dataRepository.GetAllAsync().Result;
        }

        // GET: api/Avis/5
        [HttpGet("{id}")]
        [Route("[action]/{id}")]
        [ActionName("GetById")]
        public async Task<ActionResult<Avis>> GetAvis(int id)
        {
            var avis =  dataRepository.GetByIdAsync(id).Result;

            if (avis == null)
            {
                return NotFound();
            }

            return avis;
        }

        // POST: api/Avis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Avis>> PostAvis(Avis avis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            dataRepository.AddAsync(avis);

            return CreatedAtAction("GetById", new { id = avis.SejourId }, avis); // GetById : nom de l’action
        }

        // DELETE: api/Avis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAvis(int id)
        {
            var avis = dataRepository.GetByIdAsync(id);

            if (avis == null)
            {
                return NotFound();
            }

            dataRepository.DeleteAsync(avis.Result.Value);

            return NoContent();
        }
    }
}
