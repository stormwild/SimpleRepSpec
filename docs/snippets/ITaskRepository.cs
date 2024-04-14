namespace SimpleRepSpec.Core.TaskManagement.Contracts;

public interface ITaskRepository<T> : IRepository<T, int> where T : class
{

}
