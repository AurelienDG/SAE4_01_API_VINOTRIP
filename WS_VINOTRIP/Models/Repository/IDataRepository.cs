using Microsoft.AspNetCore.Mvc;

namespace WS_VINOTRIP.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        public Task<ActionResult<IEnumerable<TEntity>>> GetAllAsync();
        public Task<ActionResult<TEntity>> GetByIdAsync(int id);
        public Task<ActionResult<TEntity>> GetByStringAsync(string numen);
        public Task AddAsync(TEntity entity);
        public Task UpdateAsync(TEntity entity1, TEntity entity2);
        public Task DeleteAsync(TEntity entity);
    }
}
