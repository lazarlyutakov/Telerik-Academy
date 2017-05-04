using System;
using SchoolSystem.Core.Contracts;

namespace SchoolSystem.Core
{
    public class Engine
    {
        private const string NullProvidersExceptionMessage = "The provider cannot be null";

        private IReader reader;
        private IWriter writer;
        private IParser parser;

        public Engine(IReader readerProvider, IWriter writerProvider, IParser parserProvider)
        {
            if (readerProvider == null)
            {
                throw new ArgumentNullException($"Reader {NullProvidersExceptionMessage}");
            }

            if (writerProvider == null)
            {
                throw new ArgumentNullException($"Writer {NullProvidersExceptionMessage}");
            }

            if (parserProvider == null)
            {
                throw new ArgumentNullException($"Parser {NullProvidersExceptionMessage}");
            }

            this.reader = readerProvider;
            this.writer = writerProvider;
            this.parser = parserProvider;
        }

        public void Start()
        {
            while (true)
            {
                try
                {
                    var command = this.reader.Read();

                    if (command == "End")
                    {
                        break;
                    }

                    this.ProcessCommand(command);
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

            var output = command.Execute(parameters);
            this.writer.WriteLine(output);
        }
    }
}
