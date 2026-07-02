using IntelligencePipeline.Models.Reports;
using IntelligencePipeline.Models.Enums;
namespace IntelligencePipeline.Calculators
{
    class PriorityCalculator
    {
        public Priority Calculate(Report report) 
        {
            string desc = report.Description.ToLower();
            if (desc.Contains("fire") || desc.Contains("attack") || desc.Contains("missile") || desc.Contains("explosion")) { return Priority.Critical;  }
            if (report is SignalReport signal)
            {
                string cont = signal.Content.ToLower(); 
                if (cont.Contains("target") && cont.Contains("attack")) { return Priority.Critical;}
                if (cont.Contains("fire") || cont.Contains("attack") || cont.Contains("missile") || cont.Contains("explosion")) { return Priority.Critical; }          
            }
            if (report is RadarReport radar)
            {
                if (radar.Speed >= 800) { return Priority.Critical; }
                if (radar.Speed >= 400) { return Priority.High; }
                if (radar.Speed >= 120) { return Priority.Medium; }
            }

            if (desc.Contains("weapon") || desc.Contains("suspicious") || desc.Contains("border")) { return Priority.High; }
            if (report is DroneReport drone)
            {
                if (drone.Altitude > 500) { return Priority.High; }
            }
            if (report is SoldierReport soldier)
            {
                if (soldier.ConfidenceLevel >= 4 && desc.Contains("movement")){ return Priority.High; }
            }
            if (desc.Contains("movement") || desc.Contains("vehicle") || desc.Contains("activity")) { return Priority.Medium; }
            if (report.CalculateReliabilityScore() >= 7) { return Priority.Medium; }

            return Priority.Low; 
        }
    }
}