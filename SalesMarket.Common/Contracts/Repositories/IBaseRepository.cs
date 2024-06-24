namespace SalesMarket.Common.Contracts.Repositories
{
    public interface IBaseRepository<Entity, Dto>
    {
        Task<IEnumerable<Dto>> GetAllAsync();
        Task<Dto> GetByIdAsync(int id);
        Task AddAsync(Entity entity);
        Task UpdateAsync(Entity entity);
        Task DeleteAsync(int id);
    }
}
