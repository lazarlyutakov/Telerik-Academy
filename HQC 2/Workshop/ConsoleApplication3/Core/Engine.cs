using SchoolSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Core
{
    internal class Engine
    {
        private const string END_PROCESS_COMMAND = "End";
        private const string NULL_EXCEPTION_MESSAGE = "Make an input! The value cannot be null!";

        private IReader reader;
        private IWriter writer;
        private IParser parser;

        public Engine(IReader reader, IWriter writer, IParser parser)
        {
            if (reader == null)
            {
                throw new ArgumentOutOfRangeException(NULL_EXCEPTION_MESSAGE);
            }

            if (writer == null)
            {
                throw new ArgumentOutOfRangeException(NULL_EXCEPTION_MESSAGE);
            }

            if (parser == null)
            {
                throw new ArgumentOutOfRangeException(NULL_EXCEPTION_MESSAGE);
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

                    if (commandAsString == END_PROCESS_COMMAND)
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
