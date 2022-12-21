using EM.Domain;
using System.Linq.Expressions;

namespace EM.Repository;
public abstract class RepositorioAbstrato<T> where T : IEntidade
{
    public abstract void Add(T entity);
    public abstract void Remove(T entity);
    public abstract void Update(T entity);
    public abstract IEnumerable<T> GetAll();
    public abstract IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
}
