using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Tasker
    {

        private ILogger logger;
        private IIdProvider idProvider;

        public ICollection<Task> Tasks { get; set; }

        public Tasker(ILogger logger, IIdProvider idProvider)
        {
            this.Tasks = new List<Task>();
            this.logger = logger;
            this.idProvider = idProvider;
        }


        public void Save(Task task)
        {
            if(task == null)
            {
                throw new ArgumentNullException();
            }

            task.Id = this.idProvider.Id;
            this.Tasks.Add(task);
            this.logger.Log(string.Format("Added task with {0}", task.Id));
        }

        public void Delete(int id)
        {

            var taskFound = this.Tasks.SingleOrDefault(task => task.Id == id);
    
            if(taskFound == null)
            {
                this.logger.Log($"task with {id} is not found !");
                return;
            }

            this.Tasks.Remove(taskFound);
            this.logger.Log($"Task with {id} has benn removed !");
        }

        public void AllTasks()
        {
            foreach (var task in this.Tasks)
            {
                this.logger.Log($"task [{task.Id}]");
            }
        }
    }
}
