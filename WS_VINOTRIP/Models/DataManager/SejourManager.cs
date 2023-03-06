using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WS_VINOTRIP.Models.EntityFramework;
using WS_VINOTRIP.Models.Repository;

namespace WS_VINOTRIP.Models.DataManager
{
    public class SejourManager : IDataRepository<Sejour>
    {
        readonly VinotripDBContext? vinotripDbContext;
        public SejourManager() { }

        public SejourManager(VinotripDBContext context)
        {
            vinotripDbContext = context;
        }

        public async Task<ActionResult<IEnumerable<Sejour>>> GetAllAsync()
        {
            return await vinotripDbContext.Sejours.ToListAsync();
        }

        public async Task<ActionResult<Sejour>> GetByIdAsync(int id)
        {
            return await vinotripDbContext.Sejours.FirstOrDefaultAsync(e => e.SejourId == id);
        }

        public async Task<ActionResult<Sejour>> GetByStringAsync(string titre)
        {
            return await vinotripDbContext.Sejours.FirstOrDefaultAsync(u => u.TitreSejour.ToUpper() == titre.ToUpper());
        }

        public async Task AddAsync(Sejour entity)
        {
            await vinotripDbContext.Sejours.AddAsync(entity);
            await vinotripDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Sejour sejour, Sejour entity)
        {
            vinotripDbContext.Entry(sejour).State = EntityState.Modified;
            sejour.SejourId = entity.SejourId;
            sejour.RouteVinId = entity.RouteVinId;
            sejour.CatSejourId = entity.CatSejourId;
            sejour.CatVignobleId = entity.CatVignobleId;
            sejour.TitreSejour = entity.TitreSejour;
            sejour.DescriptionSejour = entity.DescriptionSejour;
            sejour.PrixSejour = entity.PrixSejour;
            sejour.NbJour = entity.NbJour;
            sejour.NbNuit = entity.NbNuit;
            sejour.Promotion = entity.Promotion;
            sejour.Est_Valide = entity.Est_Valide;
            sejour.SejourRouteDesVins = entity.SejourRouteDesVins;
            sejour.SejourCatSejour = entity.SejourCatSejour;
            sejour.SejourCatVignoble = entity.SejourCatVignoble;
            sejour.EtapesSejour = entity.EtapesSejour;
            sejour.PanierSejour = entity.PanierSejour;
            sejour.ComporteSejour = entity.ComporteSejour;
            await vinotripDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Sejour sejour)
        {
            vinotripDbContext.Sejours.Remove(sejour);
            await vinotripDbContext.SaveChangesAsync();
        }
    }
}
