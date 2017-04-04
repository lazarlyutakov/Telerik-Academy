using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Students : People, IComments
    {
        private readonly int classNumber;
        private List<string> optionalComment = new List<string>();

        public int ClassNumber { get { return this.classNumber; } }
        public List<string> OptionalComments { get { return this.optionalComment; } }

        public Students(string name, int classNumber) : base(name)
        {
            this.classNumber = classNumber;
        }

        public Students(string name, int classNumber, string comment) : base(name)
        {
            this.classNumber = classNumber;
            this.optionalComment.Add(comment); 
        }



        public void AddComment(string commentToAdd)
        {
           this.optionalComment.Add(commentToAdd);
        }


        public void RemoveComment(string commentToRemove)
        {
            this.optionalComment.Remove(commentToRemove);
        }

    }
}
