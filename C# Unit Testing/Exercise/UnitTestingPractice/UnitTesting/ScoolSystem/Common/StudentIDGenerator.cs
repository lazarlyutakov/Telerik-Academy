using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoolSystem.Common
{
   internal static class StudentIDGenerator
    {
        internal static List<uint> allIDs;

        static StudentIDGenerator()
        {
            allIDs = new List<uint>();
            //randomGen = new Random();
        }

        public static uint GenerateID(uint id)
        {
            //var id = randomGen.Next(GlobalConstants.MinStudentID, GlobalConstants.MaxStudentID + 1);

            if (allIDs.Contains(id))
            {
                throw new ArgumentException(string.Format("This id {0} is already used!", id));
                
            }
            else
            {
                allIDs.Add(id);
            }
            return id;
        }
    }
}
