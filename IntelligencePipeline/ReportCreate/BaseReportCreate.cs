using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.DroneReportCreate
{
    class ReportCreate
    {
        static DateTime SetDatetime()
        {
            string datetime = "";
            DateTime dt;
            while (!DateTime.TryParse(datetime, out dt))
            {
                Console.WriteLine("Enter date and time");
                datetime = Console.ReadLine();
            }
            return dt;
        }

        static double SetLatitude()
        {
            double ltd;
            string latitude = "";
            while (double.TryParse(latitude, out ltd))
            {
                Console.WriteLine("Enter latitude");
                latitude = Console.ReadLine();
            }
            return ltd;
        }

        static double SetLongitude() 
        {
            double lgt;
            string longitude = "";
            while (double.TryParse(longitude, out lgt))
            {
                Console.WriteLine("Enter longitude");
                longitude = Console.ReadLine();
            }
            return lgt;
        }

        static string SetDescription()
        {
            Console.WriteLine("Enter description");
            string description = Console.ReadLine();
            return description;
        }

        static void Main() { }
    }
}