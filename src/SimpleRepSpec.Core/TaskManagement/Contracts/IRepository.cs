using System.Linq.Expressions;

namespace SimpleRepSpec.Core.TaskManagement.Contracts;

public interface IRepository<TEntity, TId> where TEntity : class
                                           where TId : IEquatable<TId>
{
    Task<TEntity?> FindAsync(TId id, CancellationToken ct = default);
    Task<IReadOnlyList<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken ct = default);
}
