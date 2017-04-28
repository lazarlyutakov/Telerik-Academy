using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Contracts
{
    public interface IStudent
    {
        //string FirstName { get; set; }
        //string LastName { get; set; }
        //string Grade { get; set; }
        //string Mark { get; set; }

        string ListMarks();
    }
}
