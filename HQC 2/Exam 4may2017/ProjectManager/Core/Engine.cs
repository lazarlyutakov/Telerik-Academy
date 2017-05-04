using Bytes2you.Validation;
using ProjectManager.Common;
using ProjectManager.Common.Exceptions;
using ProjectManager.Common.Providers;
using ProjectManager.Core.Providers;
using ProjectManager.Data;
using ProjectManager.Models;
using System;
using System.Text;

namespace ProjectManager
{
    public class Engine
    {
        private const string TerminationCommand = "Exit";

        private FileLogger logger;
        private CommandProcessor processor;

        public Engine(FileLogger logger, CommandProcessor processor)
        {
            // validate clauses
            Guard.WhenArgument(logger, "Engine Logger provider").IsNull().Throw();

            Guard.WhenArgument(processor, "Engine Processor provider").IsNull().Throw();

            this.logger = logger;
            this.processor = processor;
        }

        public void Start()
        {
            while(true)
            {
                // read from console
                var reader = new ConsoleReaderProvider();
                var writer = new ConsoleWriterProvider();

                var commandFromInput = reader.ReadLine();

                if (commandFromInput.ToLower() == TerminationCommand.ToLower())
                {
                    Console.WriteLine("Program terminated.");
                    break;
                }

                try
                {
                    var executionResult = this.processor.Process(commandFromInput);
                    Console.WriteLine(executionResult);
                }
                catch (UserValidationException ex)
                {
                    writer.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    writer.WriteLine("Opps, something happened. :(");
                    this.logger.Error(ex.Message);
                }
            }
        }
    }
}