namespace IntelligencePipeline.ReportCreate
{
    class BaseReportCreate
    {
        public static DateTime SetDatetime()
        {
            string? datetime = "";
            DateTime dt;
            while (!DateTime.TryParse(datetime, out dt))
            {
                Console.WriteLine("Enter date and time");
                datetime = Console.ReadLine();
            }
            return dt;
        }

        public static double SetLatitude()
        {
            double ltd;
            string? latitude = "";
            while (double.TryParse(latitude, out ltd))
            {
                Console.WriteLine("Enter latitude");
                latitude = Console.ReadLine();
            }
            return ltd;
        }

        public static double SetLongitude() 
        {
            double lgt;
            string? longitude = "";
            while (double.TryParse(longitude, out lgt))
            {
                Console.WriteLine("Enter longitude");
                longitude = Console.ReadLine();
            }
            return lgt;
        }

        public static string SetDescription()
        {
            Console.WriteLine("Enter description");
            string description = Console.ReadLine();
            return description;
        }
    }
}