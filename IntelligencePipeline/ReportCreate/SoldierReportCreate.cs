using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.ReportCreate
{
    class SoldierReportCreate
    {

        static string SetSoldierID()
        {
            Console.WriteLine("Enter soldier id");
            string soldierID = Console.ReadLine();
            return soldierID;
        }

        static string SetSoldierName()
        {
            Console.WriteLine("Enter soldier name");
            string soldierName= Console.ReadLine();
            return soldierName;
        }

        static string SetUnit()
        {
            Console.WriteLine("Enter Unit");
            string unit = Console.ReadLine();
            return unit;
        }

        static int SetConfidenceLevel()
        {
            int lvl;
            string? confidence = "";
            while (int.TryParse(confidence, out lvl))
            {
                Console.WriteLine("Enter Confidence Level");
                confidence = Console.ReadLine();
            }
            return lvl;
        }

        public static SoldierReport Build()
        {
            DateTime datetime = BaseReportCreate.SetDatetime();
            double latitude = BaseReportCreate.SetLatitude();
            double longitude = BaseReportCreate.SetLongitude();
            string description = BaseReportCreate.SetDescription();
            string name = SetSoldierName();
            string soldierID = SetSoldierID();
            int confidencelevel = SetConfidenceLevel();
            string unit = SetUnit();
            return new SoldierReport(datetime, latitude, longitude, description, name, soldierID, unit, confidencelevel);
        }
    }
}