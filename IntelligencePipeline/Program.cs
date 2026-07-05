using IntelligencePipeline.Models.Reports;
using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Pipeline;
using IntelligencePipeline.Storage;
using IntelligencePipeline.ReportCreate;
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


        public static void Main()
        {
            ReportPipeline pipeline = new();
            Console.WriteLine("Enter report type:");
            string? reporttype = Console.ReadLine();
            switch (reporttype)
            {
                case "Drone":
                    DroneReport NewDroneReport = DroneReportCreate.Build();
                    pipeline.ProcessReport(NewDroneReport);
                    break;
                case "Soldier":
                    SoldierReport NewSoldierReport = SoldierReportCreate.Build();
                    pipeline.ProcessReport(NewSoldierReport);
                    break;
                case "Radar":
                    RadarReport NewRadarReport = RadarReportCreate.Build();
                    pipeline.ProcessReport(NewRadarReport);
                    break;
                case "Signal":
                    SignalReport NewSignalReport = SignalReportCreate.Build();
                    pipeline.ProcessReport(NewSignalReport);
                    break;
                default:
                    Console.WriteLine("Invalid report type");
                    break;  
            }
        }
    }
}
