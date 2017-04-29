using System.Collections.Generic;
using SchoolSystem.Models;

namespace SchoolSystem
{
    internal static class PersonnelArchive
    {
        internal static Dictionary<int, Teachers> Teachers { get; set; } = new Dictionary<int, Teachers>();

        internal static Dictionary<int, Student> Students { get; set; } = new Dictionary<int, Student>();
    }
}