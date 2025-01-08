using Microsoft.EntityFrameworkCore;
using Project.DAL.Contexts;
using Project.DAL.Entities;
using Project.DAL.Repositories.Abstractions;

namespace Project.DAL.Repositories.Concretes;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity, new()
{
    private readonly AppDbContext _context;

    public WriteRepository(AppDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public async Task CreateAsync(T entity)
    {
        await Table.AddAsync(entity);
    }

    public void Delete(T entity)
    {
        Table.Remove(entity);
    }

    public void DeleteRange(params T[] entities)
    {
        Table.RemoveRange(entities);
    }
}

public async Task<int> SaveChangeAsync()
    {
        int rows = await _context.SaveChangesAsync();
        return rows;
    }

    public void Update(T entity)
    {
        Table.Update(entity);
    }
}
