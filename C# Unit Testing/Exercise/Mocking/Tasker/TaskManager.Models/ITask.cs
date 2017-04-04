namespace TaskManager.Models
{
    using System;

    public interface ITask
    {
         int Id { get; set; }

         string Description { get; set; }

        DateTime? Deadline { get; set; }

        bool IsDone { get; set; }
    }
}