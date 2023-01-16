

using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Linq.Expressions;
using System.Security.Principal;

namespace Company.Data.Interfaces
{
    public interface IDbService
    {
        Task<bool> AnyAsync<TEntity>(Expression<Func<TEntity, bool>> expression)
        where TEntity : class, IEntity;

        Task<List<TDto>> GetAsync<TEntity, TDto>()
            where TEntity : class, IEntity
            where TDto : class;
        Task<TDto> SingleAsync<TEntity, TDto>(
            Expression<Func<TEntity, bool>> expression)
            where TEntity : class, IEntity
            where TDto : class;
        Task<TEntity> AddAsync<TEntity, TDto>(TDto dto)
            where TEntity : class, IEntity
            where TDto : class;
        Task<bool> SaveChangesAsync();

        string GetURI<TEntity>(TEntity entity)
            where TEntity : class, IEntity;

        void Update<TEntity, TDto>(int id, TDto dto) 
            where TEntity : class, IEntity
            where TDto : class;

        Task<bool> DeleteAsync<TEntity>(int id) 
            where TEntity : class, IEntity;
       

    }
}
