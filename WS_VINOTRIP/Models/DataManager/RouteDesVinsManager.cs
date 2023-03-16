using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WS_VINOTRIP.Models.EntityFramework;
using WS_VINOTRIP.Models.Repository;

namespace WS_VINOTRIP.Models.DataManager
{
    public class RoutesDesVinsManager : IDataRepository<RouteDesVins>
    {
        readonly VinotripDBContext? vinotripDbContext;
        public RoutesDesVinsManager()
        { }

        public RoutesDesVinsManager(VinotripDBContext context)
        {
            vinotripDbContext = context;
        }

        public async Task<ActionResult<IEnumerable<RouteDesVins>>> GetAllAsync()
        {
            return await vinotripDbContext.RouteDesVinss.ToListAsync();
        }

        public async Task<ActionResult<RouteDesVins>> GetByIdAsync(int id)
        {
            return await vinotripDbContext.RouteDesVinss.FirstOrDefaultAsync(e => e.RouteDesVinsId == id);
        }

        public async Task<ActionResult<RouteDesVins>> GetByStringAsync(string titre)
        {
            return await vinotripDbContext.RouteDesVinss.FirstOrDefaultAsync(u => u.Titre.ToUpper() == titre.ToUpper());
        }

        public async Task AddAsync(RouteDesVins entity)
        {
            await vinotripDbContext.RouteDesVinss.AddAsync(entity);
            await vinotripDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(RouteDesVins routeDesVins, RouteDesVins entity)
        {
        }

        public async Task DeleteAsync(RouteDesVins routeDesVins)
        {
            vinotripDbContext.RouteDesVinss.Remove(routeDesVins);
            await vinotripDbContext.SaveChangesAsync();
        }
    }
}

