using System.Linq.Expressions;
using CA.Domain.Entities;

namespace CA.Application.Interfaces.Repositories;

public interface IBaseRepository<T> where T : BaseEntity
{
    /// <summary>
    /// Find All
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    IQueryable<T> FindAll(bool includeDeleted);

    /// <summary>
    /// Find by Expression
    /// </summary>
    /// <param name="expression"></param>
    /// <returns></returns>
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);

    /// <summary>
    /// Create T
    /// </summary>
    /// <param name="entity"></param>
    void Create(T entity);

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