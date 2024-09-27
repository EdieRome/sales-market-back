using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SalesMarket.Common.Contracts.Repositories;

namespace SalesMarket.Repositories.Repositories
{
    public class BaseRepository<Entity, Dto> : IBaseRepository<Entity, Dto> where Entity : class
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public BaseRepository(DatabaseContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public virtual async Task<IEnumerable<Dto>> GetAllAsync()
        {
            var result = await _context.Set<Entity>().ToListAsync();
            return _mapper.Map<List<Dto>>(result);
        }

        public virtual async Task<Dto> GetByIdAsync(int id)
        {
            var result = await _context.Set<Entity>().FindAsync(id);
            return _mapper.Map<Dto>(result);
        }

        public virtual async Task AddAsync(Entity entity)
        {
            await _context.Set<Entity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(Entity entity)
        {
            _context.Set<Entity>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(int id)
        {
            var item = await _context.Set<Entity>().FindAsync(id);
            if (item is not null)
            {
                _context.Set<Entity>().Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}