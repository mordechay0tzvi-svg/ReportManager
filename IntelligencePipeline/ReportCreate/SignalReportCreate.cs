using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.ReportCreate
{
    class SignalReportCreate
    {
        static double SetFrequency()
        {
            double frq;
            string? frequency = "";
            while (double.TryParse(frequency, out frq))
            {
                Console.WriteLine("Enter frequency");
                frequency = Console.ReadLine();
            }
            return frq;
        }

        static int SetSignalStrength()
        {
            int signal;
            string? strength = "";
            while (int.TryParse(strength, out signal))
            {
                Console.WriteLine("Enter Signal Strength");
                strength = Console.ReadLine();
            }
            return signal;
        }

        static string SetContent()
        {   
            Console.WriteLine("Enter content");
            string content = Console.ReadLine();
            return content;
        }

        static Language SetLanguage()
        {
            Language lng;
            string? Language = "";
            while (Enum.TryParse<Language>(Language, out lng))
            {
                Console.WriteLine("Enter Language");
                Language = Console.ReadLine();
            }
            return lng;
        }

        public static SignalReport Build()
        {
            DateTime datetime = BaseReportCreate.SetDatetime();
            double latitude = BaseReportCreate.SetLatitude();
            double longitude = BaseReportCreate.SetLongitude();
            string description = BaseReportCreate.SetDescription();
            Language language = SetLanguage();
            string content = SetContent();
            double frequency = SetFrequency();
            int signalStrebgth = SetSignalStrength();

            return new SignalReport(datetime, latitude, longitude, description, frequency, content, language, signalStrebgth);
        }
    }
}