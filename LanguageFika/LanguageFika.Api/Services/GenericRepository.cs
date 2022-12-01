using System.Linq.Expressions;
using LanguageFika.Api.Context;
using Microsoft.EntityFrameworkCore;

namespace LanguageFika.Api.Services;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{

    protected AppDbContext _context;
    internal DbSet<T> dbSet;
    
    public GenericRepository(AppDbContext context)
    {
        _context = context;
        dbSet = _context.Set<T>();
    }
    
    public virtual async Task<T> GetById(Guid id)
    {
        return (await dbSet.FindAsync(id))!;
    }
    
    public virtual async Task<IEnumerable<T>> All()
    {
        return await dbSet.ToListAsync();
    }
    
    public virtual async Task<bool> Add(T entity)
    {
        await dbSet.AddAsync(entity);
        return await _context.SaveChangesAsync() > 0;
    }
    
    public virtual async Task<bool> Upsert(T entity)
    {
        dbSet.Update(entity);
        return await _context.SaveChangesAsync() > 0;
    }
    
    public virtual Task<bool> Delete(Guid id)
    {
        var entity = dbSet.Find(id);
        if (entity == null)
        {
            return Task.FromResult(false);
        }
        dbSet.Remove(entity);
        _context.SaveChanges();
        return Task.FromResult(true);
    }
    
    public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
    {
        return await dbSet.Where(predicate).ToListAsync();
    }
    
}