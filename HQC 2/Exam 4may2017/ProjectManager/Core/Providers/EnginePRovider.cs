using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Core.Providers
{
    public class EngineProvider
    {
        private Engine engine;

        public EngineProvider(Engine engine)
        {
            this.engine = engine;
        }

        public void Initialize()
        {
            engine.Start();
        }
    }
}
