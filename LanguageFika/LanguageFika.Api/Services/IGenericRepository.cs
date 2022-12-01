using System.Linq.Expressions;

namespace LanguageFika.Api.Services;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetById(Guid id);
    Task<IEnumerable<T>> All();
    Task<bool> Add(T entity);
    Task<bool> Upsert(T entity);
    Task<bool> Delete(Guid id);
    
    Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
}