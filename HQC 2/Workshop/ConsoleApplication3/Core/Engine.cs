using SchoolSystem.Contracts;
using System;

namespace SchoolSystem.Core
{
    internal class Engine
    {
        private const string EndProcessCOmmand = "End";
        private const string NullExceptionMEssage = "Make an input! The value cannot be null!";

        private IReader reader;
        private IWriter writer;
        private IParser parser;

        public Engine(IReader reader, IWriter writer, IParser parser)
        {
            if (reader == null)
            {
                throw new ArgumentOutOfRangeException(NullExceptionMEssage);
            }

            if (writer == null)
            {
                throw new ArgumentOutOfRangeException(NullExceptionMEssage);
            }

            if (parser == null)
            {
                throw new ArgumentOutOfRangeException(NullExceptionMEssage);
            }

            this.reader = reader;
            this.writer = writer;
            this.parser = parser;
        }

        public void Start()
        {
            while (true)
            {
                try
                {
                    var commandAsString = this.reader.ReadLine();

                    if (commandAsString == EndProcessCOmmand)
                    {
                        break;
                    }

                    this.ProcessCommand(commandAsString);
                }
                catch (Exception ex)
                {
                    this.writer.WriteLine(ex.Message);
                }
            }
        }

        private void ProcessCommand(string commandAsString)
        {
            if (string.IsNullOrWhiteSpace(commandAsString))
            {
                throw new ArgumentNullException("Command cannot be null or empty.");
            }

            var command = this.parser.ParseCommand(commandAsString);
            var parameters = this.parser.ParseParameters(commandAsString);

            var executionResult = command.Execute(parameters);
            this.writer.WriteLine(executionResult);
        }
    }
}