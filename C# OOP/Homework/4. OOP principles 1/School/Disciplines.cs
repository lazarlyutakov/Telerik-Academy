using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Disciplines
    {
        private string nameOfLecture;
        private int numberOfLectures;
        private int numberOfExercises;
        

        public string NameOfLecture
        {
            get { return this.nameOfLecture; }
        }  

        public int NumberOfLectures { get; private set; }
        public int NumberOfExercises { get; private set; }

         

        public Disciplines(string nameOfLecture, int numberOfLectures, int numberOfExercises)
        {
            this.nameOfLecture = nameOfLecture;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }
    }
}
