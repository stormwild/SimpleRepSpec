using Microsoft.EntityFrameworkCore;

namespace SimpleRepSpec.Infrastructure.TaskManagementPersistence;

public class TaskDbContext : DbContext
{
    public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
    {
    }

    public DbSet<Task> Tasks { get; set; } = null!;
    public DbSet<Assignee> Assignees { get; set; } = null!;
    public DbSet<Label> Labels { get; set; } = null!;
    public DbSet<TaskLabel> TaskLabels { get; set; } = null!;
    public DbSet<TaskAssignee> TaskAssignees { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TaskLabel>()
            .HasKey(tl => new { tl.TaskId, tl.LabelId });

        modelBuilder.Entity<TaskAssignee>()
            .HasKey(ta => new { ta.TaskId, ta.AssigneeId });
    }
}
