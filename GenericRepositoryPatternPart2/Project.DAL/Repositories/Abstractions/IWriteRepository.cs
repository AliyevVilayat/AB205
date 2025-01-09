using Project.DAL.Entities.Common;

namespace Project.DAL.Repositories.Abstractions;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity, new()
{
    //Create
    //Update
    //Delete
    //SaveChange

    Task CreateAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    void DeleteRange(params T[] entities);
    Task<int> SaveChangeAsync();

}
