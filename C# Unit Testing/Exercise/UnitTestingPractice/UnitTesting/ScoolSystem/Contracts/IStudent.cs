using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoolSystem.Contracts
{
    public interface IStudent
    {
        string Name { get; }

        uint ID { get; }

        IEnumerable<string> Courses { get; }
    }
}
