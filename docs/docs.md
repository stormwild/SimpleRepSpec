# Docs

```csharp
namespace SimpleRepSpec.Core.TaskManagement.Contracts;

public interface IRepository<TEntity> where TEntity : class
{
    // Task<TEntity> GetByIdAsync(Guid id);
    // Task<TEntity> AddAsync(TEntity entity);
    // Task<TEntity> UpdateAsync(TEntity entity);
    // Task DeleteAsync(Guid id);
    Task<IEnumerable<TEntity>> GetAllAsync();
}

``` 
