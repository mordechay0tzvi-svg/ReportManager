using IntelligencePipeline.Models.Reports;
using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Pipeline;
using IntelligencePipeline.Storage;
namespace program
{
    class Program
    {
        private static void DisplayReport(Report report)
        {

        }
        private static void DisplayValidatedReports(ReportRepository repository)
        {

        }
        private static void DisplayRejectedReports(RejectedReportRepository repository)
        {

        }


        public static void Main(string[] args)
        {
            string reporttype = "";
            while (!new List<string> { "Drone", "Soldier", "Radar", "Signal" }.Contains(reporttype))
            {
                Console.WriteLine("Enter report type:");
                reporttype = Console.ReadLine();
            }

            string datetime = "";
            while (!DateTime.TryParse(datetime, out DateTime dt))
            {
                Console.WriteLine("Enter date and time");
                datetime = Console.ReadLine(); 
            }

            string latitude = "";
            while (double.TryParse(latitude, out double ltd))
            {
                Console.WriteLine("Enter latitude");
                latitude = Console.ReadLine();
            }

            string longitude = "";
            while (double.TryParse(longitude, out double lgt))
            {
                Console.WriteLine("Enter longitude");
                longitude = Console.ReadLine();
            }
            
            Console.WriteLine("Enter description");
            string description = Console.ReadLine();

           
        }
    }
}