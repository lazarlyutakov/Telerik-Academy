using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Core.Providers
{
    class EnginePRovider
    {
        private Engine engine;

        public EnginePRovider(Engine engine)
        {
            this.engine = engine;
        }

        public void Initialize()
        {
            engine.Start();
        }
    }
}
