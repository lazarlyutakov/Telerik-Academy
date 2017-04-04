using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Utils.Contracts;
using Academy.Models.Enums;
using Academy.Models.Contracts;
using System.Globalization;

namespace Academy.Models
{
   public class Lecture : ILecture
    {
        private string name;
        private DateTime date;
        private ITrainer trainer;
        private IList<ILectureResouce> resources;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if( value.Length < 5 || value.Length > 30)
                {
                    throw new ArgumentOutOfRangeException("Lecture's name should be between 5 and 30 symbols long!");
                }
                this.name = value;
            }
        }

        public DateTime Date { get; set; }

        public ITrainer Trainer { get; set; }

        public IList<ILectureResouce> Resouces { get; }

        public Lecture(string name, DateTime date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = date;
            this.Trainer = trainer;
            this.Resouces = resources;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, @"*Lecture
                                                                 - Name: {0}
                                                                 - Date: {1}
                                                                 - Trainer username: {2}
                                                                 - Resources: {3}",
                                                                 this.Name, this.Date, this.Trainer.Username, this.Resouces);
        }


    }
}
