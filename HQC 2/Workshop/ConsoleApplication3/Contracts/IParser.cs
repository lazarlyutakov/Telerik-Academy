using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Contracts
{
    public interface IParser
    {
        ICommand ParseCommand(string fullCommand);

        IList<string> ParseParameters(string fullCommand);
    }
}
