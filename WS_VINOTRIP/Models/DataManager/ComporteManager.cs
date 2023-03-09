using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WS_VINOTRIP.Models.EntityFramework;
using WS_VINOTRIP.Models.Repository;

namespace WS_VINOTRIP.Models.DataManager
{
    public class ComporteManager : IDataRepository<Comporte>
    {

        readonly VinotripDBContext? vinotripDbContext;
        public ComporteManager()
        { }

        public ComporteManager(VinotripDBContext context)
        {
            vinotripDbContext = context;
        }

        public Task AddAsync(Comporte entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Comporte entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<IEnumerable<Comporte>>> GetAllAsync()
        {
            return await vinotripDbContext.Comportes.ToListAsync();
        }

        public async Task<ActionResult<Comporte>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Comporte>> GetByStringAsync(string numen)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Comporte entity1, Comporte entity2)
        {
            throw new NotImplementedException();
        }
    }
}
