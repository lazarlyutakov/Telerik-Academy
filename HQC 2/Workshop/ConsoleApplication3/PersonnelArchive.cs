using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal static class PersonnelArchive
    {
        //private static Dictionary<int, Teachers> teachers;
        //private static Dictionary<int, Student> students;

        //public PersonnelArchive()
        //{
            
        //}

        internal static Dictionary<int, Teachers> Teachers { get; set; } = new Dictionary<int, Teachers>();
        internal static Dictionary<int, Student> Students { get; set; } = new Dictionary<int, Student>();
    }
}
