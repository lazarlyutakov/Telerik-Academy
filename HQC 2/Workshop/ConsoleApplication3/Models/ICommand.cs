using System.Collections.Generic;

namespace ConsoleApplication3
{
    public interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
