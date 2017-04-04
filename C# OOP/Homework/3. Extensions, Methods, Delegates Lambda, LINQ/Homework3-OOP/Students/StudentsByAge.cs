using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class StudentsByAge
    {

        public void NamesByAge()
        {

            var studentsList = new[]
                {
              new {firstName = "Ivan", surname = "Draganov", age = 18},
              new {firstName = "Peter", surname ="Ivanov", age = 19},
              new {firstName = "Gosho", surname ="Todorov", age = 28},
              new {firstName = "Petkan", surname = "Tomov", age = 25},
              new {firstName = "Dragan", surname = "Georgiev", age = 23},
              new {firstName = "Nane", surname = "Vutov", age = 20}
            };
        }
    }
}