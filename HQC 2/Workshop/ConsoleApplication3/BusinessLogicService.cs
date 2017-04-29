using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    // I am not sure if we need this, but too scared to delete. 
    internal class BusinessLogicService
    {
        public void Execute(ConsoleReaderProvider reader)
        {
            var engine = new Engine(reader);
            engine.BrumBrum();
        }
    }
}
