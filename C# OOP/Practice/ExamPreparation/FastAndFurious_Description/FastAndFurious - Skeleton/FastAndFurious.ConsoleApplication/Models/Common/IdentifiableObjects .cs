using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastAndFurious.ConsoleApplication.Common.Utils;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.Common
{
    public class IdentifiableObjects
    {
        private readonly int id;

        public IdentifiableObjects()
        {
            this.id = DataGenerator.GenerateId();
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }
    }
}
