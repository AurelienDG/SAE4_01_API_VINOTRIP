using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WS_VINOTRIP.Models.EntityFramework;
using WS_VINOTRIP.Models.Repository;

namespace WS_VINOTRIP.Models.DataManager
{
    public class VignobleManager : IDataRepository<Vignoble>
    {
        readonly VinotripDBContext? vinotripDbContext;
        public VignobleManager()
        { }

        public VignobleManager(VinotripDBContext context)
        {
            vinotripDbContext = context;
        }

        public async Task<ActionResult<IEnumerable<Vignoble>>> GetAllAsync()
        {
            return await vinotripDbContext.Vignobles.ToListAsync();
        }

        public async Task<ActionResult<Vignoble>> GetByIdAsync(int id)
        {
            return await vinotripDbContext.Vignobles.FirstOrDefaultAsync(e => e.VignobleId == id);
        }

        public async Task<ActionResult<Vignoble>> GetByStringAsync(string titre)
        {
            return await vinotripDbContext.Vignobles.FirstOrDefaultAsync(u => u.Titre.ToUpper() == titre.ToUpper());
        }

        public async Task AddAsync(Vignoble entity)
        {
            await vinotripDbContext.Vignobles.AddAsync(entity);
            await vinotripDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Vignoble Vignoble, Vignoble entity)
        {
        }

        public async Task DeleteAsync(Vignoble Vignoble)
        {
            vinotripDbContext.Vignobles.Remove(Vignoble);
            await vinotripDbContext.SaveChangesAsync();
        }
    }
}

