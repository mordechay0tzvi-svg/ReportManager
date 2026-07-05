using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.ReportCreate
{
    class DroneReportCreate
    {
        static int SetAltitude()
        {
            int alt;
            string? altitude = "";
            while (int.TryParse(altitude, out alt))
            {
                Console.WriteLine("Enter altitude");
                altitude = Console.ReadLine();
            }
            return alt;
        }

        static int SetImageQuality()
        {
            int img;
            string? quality = "";
            while (int.TryParse(quality, out img))
            {
                Console.WriteLine("Enter Image Quality");
                quality = Console.ReadLine();
            }
            return img;
        }

        public static DroneReport Build()
        {
            DateTime datetime = BaseReportCreate.SetDatetime();
            double latitude = BaseReportCreate.SetLatitude();
            double longitude = BaseReportCreate.SetLongitude();
            string description = BaseReportCreate.SetDescription();
            int altitude = SetAltitude();
            int imageQuality = SetImageQuality();
            return new DroneReport (datetime, latitude, longitude, description, altitude, imageQuality);
        }
    }
}