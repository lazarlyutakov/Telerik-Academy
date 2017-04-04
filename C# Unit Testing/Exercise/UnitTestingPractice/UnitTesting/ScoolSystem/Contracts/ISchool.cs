using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoolSystem.Models;

namespace ScoolSystem.Contracts
{
    public interface ISchool
    {
        string SchoolName { get; }

        IEnumerable<IStudent> Students { get; }

        IEnumerable<ICourse> Courses { get; }

        void AdmitStudent(IStudent student);

        void ExpellStudent(IStudent student);

        void AddCourse(ICourse course);

        void RemoveCourse(ICourse course);


    }
}
