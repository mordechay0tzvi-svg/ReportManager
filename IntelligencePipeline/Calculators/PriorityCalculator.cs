using IntelligencePipeline.Models.Reports;
using IntelligencePipeline.Models.Enums;
namespace IntelligencePipeline.Calculators
{
    class PriorityCalculator
    {
        public Priority Calculate(Report report) 
        {
            string desc = report.Description.ToLower();
            if (desc.Contains("fire") || desc.Contains("attack") || desc.Contains("missile") || desc.Contains("explosion")) { report.Priority = Priority.Critical; return; }
            if (report.GetSourceType = "Signal")
            {
                string cont = report.Content.ToLower(); 
                if (cont.Contains("target") && cont.Contains("attack")) { report.Priority = Priority.Critical; return; }
                if (cont.Contains("fire") || cont.Contains("attack") || cont.Contains("missile") || cont.Contains("explosion")) { report.Priority = Priority.Critical; return; }          
            }
            if (report.GetSourceType() == "Radar" && report.Speed >= 800) { report.Priority = Priority.Critical; return; }

            if (desc.Contains("weapon") || desc.Contains("suspicious") || desc.Contains("border")) { report.Priority = Priority.High; return; }
            if (report.GetSourceType() == "Drone" && report.Altitude > 500) { report.Priority = Priority.High; return; }
            if (report.GetSourceType() == "Radar" && report.Speed >= 400) { report.Priority = Priority.High; return; }
            if (report.GetSourceType() == "Soldier" && report.ConfidenceLevel >= 4 && desc.Contains("movement")){ report.Priority = Priority.High; return; }

            if (desc.Contains("movement") || desc.Contains("vehicle") || desc.Contains("activity")) { report.Priority = Priority.Medium; return; }
            if (report.GetSourceType() == "Radar" && report.Speed >= 120) { report.Priority = Priority.Medium; return; }
            if (report.CalculateReliabilityScore() >= 7) { report.Priority = Priority.Medium; return; }

            report.Priority = Priority.Low; return;
        }
    }
}