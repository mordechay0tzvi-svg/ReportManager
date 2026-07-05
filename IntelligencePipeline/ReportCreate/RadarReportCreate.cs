using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.ReportCreate
{
    class RadarReportCreate
    {
        static int SetSpeed()
        {
            int spd;
            string speed = "";
            while (int.TryParse(speed, out spd))
            {
                Console.WriteLine("Enter speed");
                speed = Console.ReadLine();
            }
            return spd;
        }

        static int SetDirection()
        {
            int drc;
            string? direction = "";
            while (int.TryParse(direction, out drc))
            {
                Console.WriteLine("Enter direction");
                direction = Console.ReadLine();
            }
            return drc;
        }

        static int SetDistance()
        {
            int dst;
            string? distance = "";
            while (int.TryParse(distance, out dst))
            {
                Console.WriteLine("Enter distance");
                distance = Console.ReadLine();
            }
            return dst;
        }

        public static RadarReport Build()
        {
            DateTime datetime = BaseReportCreate.SetDatetime();
            double latitude = BaseReportCreate.SetLatitude();
            double longitude = BaseReportCreate.SetLongitude();
            string description = BaseReportCreate.SetDescription();
            int speed = SetSpeed();
            int direction = SetDirection();
            int distance = SetDistance();
            return new RadarReport(datetime, latitude, longitude, description, speed, direction, distance);
        }
    }
}