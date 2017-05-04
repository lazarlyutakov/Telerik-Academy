using SchoolSystem.Core;
using SchoolSystem.Core.Providers;

namespace SchoolSystem
{
    public class Startup
    {
        static void Main()
        {
            var reader = new Reader();
            var writer = new Writer();
            var parser = new Parser();

            var engine = new Engine(reader, writer, parser);
            engine.Start();
        }
    }
}
