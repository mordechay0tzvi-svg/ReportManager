using IntelligencePipeline.Models.Reports;
using IntelligencePipeline.Models.Enums;
using System.Security.Cryptography.X509Certificates;
namespace IntelligencePipeline.Calculators
{
    class PriorityCalculator
    {
        public Priority Calculate(Report report) 
        {
            string desc = report.Description.ToLower();
            if (desc.Contains("fire") || desc.Contains("attack") || desc.Contains("missile") || desc.Contains("explosion")) { return Priority.Critical; }
            if (report.GetSourceType = "Signal")
            {
                string cont = report.Content.ToLower(); 
                if (cont.Contains("target") && cont.Contains("attack")) { return Priority.Critical; }
                if (cont.Contains("fire") || cont.Contains("attack") || cont.Contains("missile") || cont.Contains("explosion")) { return Priority.Critical; }          
            }
            if (report.GetSourceType() == "Radar" && report.Speed >= 800) { return Priority.Critical; }

            if (desc.Contains("weapon") || desc.Contains("suspicious") || desc.Contains("border")) { return Priority.High; }
            if (report.GetSourceType() == "Drone" && report.Altitude > 500) { return Priority.High; }
            if (report.GetSourceType() == "Radar" && report.Speed >= 400) { return Priority.High; }
            if (report.GetSourceType() == "Soldier" && report.ConfidenceLevel >= 4 && desc.Contains("movement") { return Priority.High; }

            if (desc.Contains("movement") || desc.Contains("vehicle") || desc.Contains("activity")) { return Priority.Medium; }
            if (report.GetSourceType() == "Radar" && report.Speed >= 120) { return Priority.Medium; }
            if (report.CalculateReliabilityScore() >= 7) { return Priority.Medium; }

            return Priority.Low;

        }
    }
}