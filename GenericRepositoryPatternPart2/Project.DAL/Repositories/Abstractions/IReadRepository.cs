using Project.DAL.Entities;
using System.Linq.Expressions;

namespace Project.DAL.Repositories.Abstractions;

public interface IReadRepository<T> : IRepository<T> where T : BaseEntity, new()
{
    //GetById
    //GetAll
    //GetByCondition
    //GetAllByCondition

    Task<T?> GetByIdAsync(int id, bool isTracking, params string[] includes);
    Task<T?> GetSingleByConditionAsync(Expression<Func<T, bool>> condition);
    IQueryable<T> GetAllByConditionAsync(Expression<Func<T, bool>> condition);

}
