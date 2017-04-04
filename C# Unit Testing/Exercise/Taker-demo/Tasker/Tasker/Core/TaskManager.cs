using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.Core.Contracts;
using Tasker.Models.Contracts;
namespace Tasker.Core
{
    public class TaskManager
    {
        private readonly IIdProvider idProvider;
        private readonly ILogger logger;


        public TaskManager(IIdProvider provider, ILogger logger)
        {
            this.idProvider = provider;
            this.logger = logger;

            this.Tasks = new List<ITask>();
        }

        public object ExposedTask { get; set; }
        protected ICollection<ITask> Tasks { get; private set; }

        public void Add(ITask task)
        {
            if(task == null)
            {
                throw new ArgumentNullException();
            }

            task.Id = this.idProvider.NextId();
            this.Tasks.Add(task);
            this.logger.Log("Task added successfully!");
        }

        public void Remove(ITask task)
        {
            if (task == null)
            {
                throw new ArgumentNullException();
            }
            if (!this.Tasks.Contains(task))
            {
                throw new ArgumentNullException();
            }
            this.Tasks.Remove(task);
            this.logger.Log("Task removed successfully!");
        }
    }
}
