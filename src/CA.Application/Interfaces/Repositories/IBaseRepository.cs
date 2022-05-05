using System.Linq.Expressions;
using CA.Domain.Entities;

namespace CA.Application.Interfaces.Repositories;

public interface IBaseRepository<T> where T : BaseEntity
{
    /// <summary>
    /// Get - Async
    /// </summary>
    /// <param name="includeDeleted">if FALSE : soft deleted records are automatically excluded</param>
    /// <returns></returns>
    Task<IQueryable<T>> GetAsync(bool includeDeleted);

    /// <summary>
    /// Get by Expression - Async
    /// </summary>
    /// <param name="expression"></param>
    /// <returns></returns>
    IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression);

    /// <summary>
    /// Add T
    /// </summary>
    /// <param name="entity"></param>
    void Add(T entity);

    /// <summary>
    /// Add Set of T
    /// </summary>
    /// <param name="entities"></param>
    void AddRange(ICollection<T> entities);

    /// <summary>
    /// Update T
    /// </summary>
    /// <param name="entity"></param>
    void Update(T entity);

    /// <summary>
    /// Mark T as Soft Deleted 
    /// </summary>
    /// <param name="entity"></param>
    void Delete(T entity);
}