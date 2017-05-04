using ScoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Core
{
    public class PersonellArchive
    {
        public static Dictionary<int, Teacher> Teachers { get; set; } = new Dictionary<int, Teacher>();

        public static Dictionary<int, Student> Students { get; set; } = new Dictionary<int, Student>();
    }
}
