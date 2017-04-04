using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSort
{
    class ExcellentMarks
    {
        public string FullName { get; set; }
        public List<float> Marks { get; set; }

        public ExcellentMarks()
        {

        }

        public ExcellentMarks(string fullName, params float[] marks)
        {
            this.FullName = fullName;
            this.Marks = new List<float>(marks);
        }

        public void NekavMetod()
        {


            ExcellentMarks neshto = new ExcellentMarks();
 
            
                }
       
    }
}
