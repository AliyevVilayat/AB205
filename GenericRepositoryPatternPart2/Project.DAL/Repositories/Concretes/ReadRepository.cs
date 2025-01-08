using Microsoft.EntityFrameworkCore;
using Project.DAL.Contexts;
using Project.DAL.Entities;
using Project.DAL.Repositories.Abstractions;
using System.Linq.Expressions;

namespace Project.DAL.Repositories.Concretes;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity, new()
{
    private readonly AppDbContext _context;

    public ReadRepository(AppDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();
    public async Task<T?> GetByIdAsync(int id, bool isTracking, params string[] includes)
    {
        IQueryable<T> query = Table.AsQueryable();

        if (!isTracking)
        {
            query = query.AsNoTracking();
        }

        if (includes.Length > 0)
        {
            foreach (string include in includes)
            {
                query = query.Include(include);
            }
        }

        T? entity = await query.SingleOrDefaultAsync(e => e.Id == id);

        return entity;
    }

    public async Task<T?> GetSingleByConditionAsync(Expression<Func<T, bool>> condition)
    {
        IQueryable<T> query = Table.AsQueryable();

        T? entity = await query.SingleOrDefaultAsync(condition);
        return entity;
    }

    public IQueryable<T> GetAllByConditionAsync(Expression<Func<T, bool>> condition)
    {
        IQueryable<T> query = Table.AsQueryable();

        query = query.Where(condition);
        return query;
    }
}
