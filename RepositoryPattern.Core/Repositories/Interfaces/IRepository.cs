namespace RepositoryPattern.Core.Repositories.Interfaces;

public interface IRepository<T> where T : class
{
    public T Get(Expression<Func<T, bool>> filter);
    // public void Create(T entity);
    // public IEnumerable<T> GetAll();
    // public void Update(T entity);
    // public void Delete(T entity);
}