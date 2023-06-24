using RepositoryPattern.Core.Repositories.Interfaces;

namespace RepositoryPattern.Data.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _dbContext;
    private readonly DbSet<T> _dbSet;

    public Repository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }

    public T Get(Expression<Func<T, bool>> filter)
        => _dbSet.FirstOrDefault(filter)
            ?? throw new ArgumentNullException(nameof(_dbSet));
}