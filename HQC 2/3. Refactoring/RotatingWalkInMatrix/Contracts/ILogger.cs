﻿namespace GameFifteen.Contracts
{
    public interface ILogger
    {
        void Write(string message);

        void WriteLine(string message);
    }
}
