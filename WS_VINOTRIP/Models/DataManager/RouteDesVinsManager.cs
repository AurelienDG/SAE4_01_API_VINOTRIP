using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WS_VINOTRIP.Models.EntityFramework;
using WS_VINOTRIP.Models.Repository;

namespace WS_VINOTRIP.Models.DataManager
{
    public class RouteDesVinsManager : IDataRepository<RouteDesVins>
    {
        readonly VinotripDBContext? vinotripDbContext;
        public RouteDesVinsManager()
        { }

        public RouteDesVinsManager(VinotripDBContext context)
        {
            vinotripDbContext = context;
        }

        public async Task<ActionResult<IEnumerable<RouteDesVins>>> GetAllAsync()
        {
            return await vinotripDbContext.RoutesDesVins.ToListAsync();
        }

        public async Task<ActionResult<RouteDesVins>> GetByIdAsync(int id)
        {
            return await vinotripDbContext.RoutesDesVins.FirstOrDefaultAsync(e => e.RouteDesVinsId == id);
        }

        public async Task<ActionResult<RouteDesVins>> GetByStringAsync(string titre)
        {
            return await vinotripDbContext.RoutesDesVins.FirstOrDefaultAsync(u => u.Titre.ToUpper() == titre.ToUpper());
        }

        public async Task AddAsync(RouteDesVins entity)
        {
            await vinotripDbContext.RoutesDesVins.AddAsync(entity);
            await vinotripDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(RouteDesVins routeDesVins, RouteDesVins entity)
        {
        }

        public async Task DeleteAsync(RouteDesVins routeDesVins)
        {
            vinotripDbContext.RoutesDesVins.Remove(routeDesVins);
            await vinotripDbContext.SaveChangesAsync();
        }
    }
}

