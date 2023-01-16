
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

        public async Task<List<TDto>> GetAsync<TEntity, TDto>()
            where TEntity : class, IEntity
            where TDto : class
        {
            var entities = await _db.Set<TEntity>().ToListAsync();
            return _mapper.Map<List<TDto>>(entities);
           
        }

        private async Task<TEntity?> SingleAsync<TEntity>(
            Expression<Func<TEntity, bool>> expression)
            where TEntity : class, IEntity =>
            await _db.Set<TEntity>().SingleOrDefaultAsync(expression);

        public async Task<TDto> SingleAsync<TEntity, TDto>(
            Expression<Func<TEntity, bool>> expression)
            where TEntity : class, IEntity
            where TDto : class
        {
            var entity = await SingleAsync(expression);
            return _mapper.Map<TDto>(entity);
            
        }
    }
}
