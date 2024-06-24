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
            var response = await _context.Set<Entity>().ToListAsync();
            return _mapper.Map<List<Dto>>(response);
        }

        public virtual async Task<Dto> GetByIdAsync(int id)
        {
            var response = await _context.Set<Entity>().FindAsync(id);
            return _mapper.Map<Dto>(response);
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
            var articulo = await _context.Set<Entity>().FindAsync(id);
            if (articulo != null)
            {
                _context.Set<Entity>().Remove(articulo);
                await _context.SaveChangesAsync();
            }
        }
    }
}