using ProjectManager.Enumerations;

namespace ProjectManager.Models.Contracts
{
    public interface ITask
    {
        string Name { get; }

        IUser Owner { get; }

        TaskState State { get; }

        string ToString();
    }
}
