namespace SimpleRepSpec.Core.TaskManagement.Entities;

public class Task
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Priority { get; set; }
    public bool IsComplete { get; set; }

}
