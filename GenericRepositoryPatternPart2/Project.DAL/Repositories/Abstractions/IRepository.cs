using Microsoft.EntityFrameworkCore;
using Project.DAL.Entities;

namespace Project.DAL.Repositories.Abstractions;

public interface IRepository<T> where T : BaseEntity, new()
{
    DbSet<T> Table { get; }
}
