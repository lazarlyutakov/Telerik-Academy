﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Core.Providers.Contracts
{
    public interface IConsoleWriterProvider
    {
        void Write(string message);

        void WriteLine(string message);
    }
}
