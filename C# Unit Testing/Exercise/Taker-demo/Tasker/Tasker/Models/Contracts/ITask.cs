using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tasker.Models.Contracts
{
    public interface ITask
    {
        int Id { get; set; }

        string Description { get; set; }
    }
}
