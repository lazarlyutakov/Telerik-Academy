using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public interface IComments
    {
        List<string> OptionalComments { get; }
        void AddComment(string comment);
        void RemoveComment(string comment);
    }
}
