using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

using SimpleRepSpec.Core.TaskManagement.Contracts;

namespace SimpleRepSpec.Infrastructure.TaskManagementPersistence.Repositories;

public class Repository<TEntity, TId, TDbContext> : IRepository<TEntity, TId>
                                                        where TEntity : class
                                                        where TId : IEquatable<TId>
                                                        where TDbContext : DbContext
{
    private readonly TDbContext _ctx;

    public Repository(TDbContext ctx)
    {
        _ctx = ctx;
    }

    public async Task<TEntity?> FindAsync(TId id, CancellationToken ct = default)
    {
        ArgumentNullException.ThrowIfNull(id);
        return await _ctx.FindAsync<TEntity>(id, ct);
    }

    public async Task<IReadOnlyList<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken ct)
    {
        return await _ctx.Set<TEntity>().Where(predicate).ToListAsync(ct);
    }
}
