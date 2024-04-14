using Microsoft.EntityFrameworkCore;

namespace SimpleRepSpec.Infrastructure.TaskManagementPersistence;

public class TaskDbContext : DbContext
{
    public DbSet<Task> Tasks { get; set; }
}
