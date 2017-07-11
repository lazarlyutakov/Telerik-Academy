using Ninject;
using System;
using System.Drawing;
using System.Linq;
using TacoMovies.ConsoleClient.Container;
using TacoMovies.ConsoleExtensions;
using TacoMovies.Contracts;
using TacoMovies.Data;
using TacoMovies.Framework.Providers;
using TacoMovies.ReportService;


namespace TacoMovies.ConsoleClient
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var dbContext = new MoviesDbContext();
            var postgre = new TacoMovies.Data.Postgre.MoviesDbContext();
            StartDemoExtendedConsole();

            var kernel = new StandardKernel(new MoviesNinjectModule());
            var engine = kernel.Get<IEngine>();
            engine.Start();

        }

        private static void StartDemoExtendedConsole()
        {
            new ConsoleGUI().SetUp();
            var extendedWriter = new ExtendedConsoleWriter(new ConsoleWriter());
            extendedWriter.WriteAscii("Taco Movies", Color.Crimson);
            // extendedWriter.WriteProgress("Query from DB ...", Color.Aqua);

            //extendedWriter.WriteLine("Movies blah, blah");
            //extendedWriter.WriteLine("ddd");
        }

        private static void StartDemoReportService()
        {
            var reportService = new ReportServiceProvider("../../../ExternalData/Reports/TacoActorsReport.pdf");
            reportService.Start();
        }

    }
}







//var parser = new MasterParser(dbContext);
//parser.Parse("../../../ExternalData/Countries.json", "../../../ExternalData/artist.json",
//"../../../ExternalData/movies.json");
// StartDemoReportService();