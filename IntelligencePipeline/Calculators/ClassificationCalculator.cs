using IntelligencePipeline.Models.Reports;
using IntelligencePipeline.Models.Enums;
namespace IntelligencePipeline.Calculators
{
    class ClassificationCalculator
    {
        public Classification Calculate(Report report)
        {
            if (report.Priority == Priority.Critical) { return Classification.TopSecret; }
            if (report.GetSourceType = "Signal")
            {
                string cont = report.Content.ToLower();
                if (cont.Contains("target") || cont.Contains("attack") || cont.Contains("missle")) { return Classification.TopSecret; }
            }

            if (report.Priority == Priority.High) { return Classification.Secret; }
            if (report.GetSourceType() == "Signal") { return Classification.Secret; }
            if (cont.Contains("weapon") || cont.Contains("border")) { return Classification.Secret;  }

            if (report.Priority == Priority.Medium) { return Classification.Restricted; }
            if (report.GetSourceType() == "Soldier") { return Classification.Restricted; }

            return Classification.Unclassified; 
        }
    }
}