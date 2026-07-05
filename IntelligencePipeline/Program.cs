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
            Console.WriteLine(report.ToString());

        }
        private static void DisplayValidatedReports(ReportRepository repository)
        {
            foreach(Report report in repository.GetAll())
            {
                DisplayReport(report);
            }
        }
        private static void DisplayRejectedReports(RejectedReportRepository repository)
        {
            foreach (Report report in repository.GetAll())
            {
                DisplayReport(report);
            }
        }

        static void ReportsByHand(ReportPipeline pipeline)
        {
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

        static void ReportsByFile(ReportPipeline pipeline, List<string> args)
        {
            foreach (string line in args)
            {
                string[] report = line.Split(',');
                if (report.Length < 5) { continue; }
                string type = report[0];
                if (!Enum.TryParse<DateTime>(report[1], out DateTime datetime)) { continue; }
                if (!double.TryParse(report[2], out double latitude)) { continue; }
                if (!double.TryParse(report[3], out double longitude)) { continue; }
                string description = report[4];
                switch (type)
                {
                    case "Soldier":
                        if (report.Length < 9) { continue; }
                        string soldierName = report[5];
                        string soldierID = report[6];
                        string unit = report[7];
                        if (!int.TryParse(report[8], out int confidenceLevel)) { continue; }
                        SoldierReport soldierreport = new SoldierReport(datetime, latitude, longitude, description, soldierName, soldierID, unit, confidenceLevel);
                        pipeline.ProcessReport(soldierreport);
                        break;

                    case "Radar":
                        if (report.Length < 8) { continue; }
                        if (!int.TryParse(report[5], out int speed)) { continue; }
                        if (!int.TryParse(report[6], out int direction)) { continue; }
                        if (!int.TryParse(report[7], out int distance)) { continue; }
                        RadarReport radarreport = new RadarReport(datetime, latitude, longitude, description, speed, direction, distance);
                        pipeline.ProcessReport(radarreport);
                        break;

                    case "Drone":
                        if (report.Length < 7) { continue; }
                        if (!int.TryParse(report[5], out int altitude)) { continue; }
                        if (!int.TryParse(report[6], out int imgqly)) { continue; }
                        DroneReport dronereport = new DroneReport(datetime, latitude, longitude, description, altitude, imgqly);
                        pipeline.ProcessReport(dronereport);
                        break;

                    case "Signal":
                        if (report.Length < 9) { continue; }
                        if (!double.TryParse(report[5], out double frequancy)) { continue; }
                        string content = report[6];
                        if (!Enum.TryParse<Language>(report[7], out Language language)) { continue; }
                        if (!int.TryParse(report[8], out int strength)) { continue; }
                        SignalReport signalreport = new SignalReport(datetime, latitude, longitude, description, frequancy, content, language, strength);
                        pipeline.ProcessReport(signalreport);
                        break;

                    default:
                        continue;
                }
            }
        }

        public static void Main()
        {
            List<string> reports = new List<string>();
            ReportPipeline pipeline = new();
            ReportsByFile(pipeline, reports);
            ReportsByHand(pipeline);
        }
    }
}
 