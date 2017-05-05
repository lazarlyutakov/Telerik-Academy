using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Core.Commands.Contracts
{
    /// <summary>
    /// Interface for the class which parses string ot ICommand.
    /// </summary>
    public interface ICommandFactory
    {
        ICommand CreateCommandFromString(string commandName);
    }
}
