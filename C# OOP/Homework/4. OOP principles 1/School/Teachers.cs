using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teachers : People, IComments, IDisciplines
    {
        private List<string> optionalComment = new List<string>();
        private List<Disciplines> disciplines = new List<Disciplines>();

        public List<string> OptionalComments { get { return this.optionalComment; } }
        public List<Disciplines> Disciplines { get { return this.disciplines; } }

        public Teachers(string name) : base(name)
        {

        }

        public Teachers(string name, string comment) : base(name)
        {
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


        public void AddDiscipline(Disciplines disciplineToAdd)
        {
            this.disciplines.Add(disciplineToAdd);
        }


        public void RemoveDiscipline(Disciplines disciplineToRemove)
        {
            this.disciplines.Remove(disciplineToRemove);
        }
    }
}
