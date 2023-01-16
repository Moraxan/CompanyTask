
using Company.Data.Interfaces;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace Company.Data.Services
{
    public class DbService : IDbService
    {

        private readonly CompanyContext _db;
        private readonly IMapper _mapper;
        public DbService(CompanyContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        async Task<List<TDto>> IDbService.GetAsync<TEntity, TDto>()

        {
            var entities = await _db.Set<TEntity>().ToListAsync();
            return _mapper.Map<List<TDto>>(entities);

        }

        private async Task<TEntity?> SingleAsync<TEntity>(
            Expression<Func<TEntity, bool>> expression)
            where TEntity : class, IEntity =>
            await _db.Set<TEntity>().SingleOrDefaultAsync(expression);

        async Task<TDto> IDbService.SingleAsync<TEntity, TDto>(
            Expression<Func<TEntity, bool>> expression)

        {
            var entity = await SingleAsync(expression);
            return _mapper.Map<TDto>(entity);

        }

        async Task<TEntity> IDbService.AddAsync<TEntity, TDto>(TDto dto)

        {
            var entity = _mapper.Map<TEntity>(dto);
            await _db.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        async Task<bool> IDbService.SaveChangesAsync() =>
            await _db.SaveChangesAsync() >= 0;

        string IDbService.GetURI<TEntity>(TEntity entity) => $"/{typeof(TEntity)}s/{entity.Id}";

        void IDbService.Update<TEntity, TDto>(int id, TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            _db.Set<TEntity>().Update(entity);
        }

        async Task<bool> IDbService.AnyAsync<TEntity>(Expression<Func<TEntity, bool>> expression)
        => await _db.Set<TEntity>().AnyAsync(expression);

        public async Task<bool> DeleteAsync<TEntity>(int id)
            where TEntity : class, IEntity                          
        {
            try
            {
                var entity = await SingleAsync<TEntity>(e => e.Id.Equals(id));
                if (entity is null) return false;
                _db.Remove(entity);
            }
            catch
            {
                throw;
            }
            return true;
        }

    }    
}
    

