using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WS_VINOTRIP.Models.EntityFramework;
using WS_VINOTRIP.Models.Repository;

namespace WS_VINOTRIP.Models.DataManager
{
    public class UserManager : IDataRepository<User>
    {
        readonly VinotripDBContext? vinotripDbContext;
        public UserManager()
        { }

        public UserManager(VinotripDBContext context)
        {
            vinotripDbContext = context;
        }

        public async Task<ActionResult<IEnumerable<User>>> GetAllAsync()
        {
            return await vinotripDbContext.Users.ToListAsync();
        }

        public async Task<ActionResult<User>> GetByIdAsync(int id)
        {
            return await vinotripDbContext.Users.FirstOrDefaultAsync(e => e.PersonneId == id);
        }

        public async Task<ActionResult<User>> GetByStringAsync(string prenom)
        {
            return await vinotripDbContext.Users.FirstOrDefaultAsync(u => u.Prenom.ToUpper() == prenom.ToUpper());
        }

        public async Task AddAsync(User entity)
        {
            await vinotripDbContext.Users.AddAsync(entity);
            await vinotripDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user, User entity)
        {
        }

        public async Task DeleteAsync(User user)
        {
            vinotripDbContext.Users.Remove(user);
            await vinotripDbContext.SaveChangesAsync();
        }
    }
}
