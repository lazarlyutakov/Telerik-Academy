using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoolSystem.Contracts
{
    public interface ICourse
    {
        string CourseName { get; }

        IEnumerable<IStudent> Students { get; }

        void AddStudent(IStudent student);

        void RemoveStudent(IStudent student);
    }
}
