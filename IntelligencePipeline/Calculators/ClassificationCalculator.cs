using IntelligencePipeline.Models.Reports;
using IntelligencePipeline.Models.Enums;
namespace IntelligencePipeline.Calculators
{
    class ClassificationCalculator
    {
        public void Calculate(Report report)
        {
            if (report.Priority == Priority.Critical) { report.Classification = Classification.TopSecret; return; }
            if (report.GetSourceType = "Signal")
            {
                string cont = report.Content.ToLower();
                if (cont.Contains("target") || cont.Contains("attack") || cont.Contains("missle")) { report.Classification = Classification.TopSecret; return; }
            }

            if (report.Priority == Priority.High) { report.Classification = Classification.Secret; return; }
            if (report.GetSourceType() == "Signal") { report.Classification = Classification.Secret; return; }
            if (cont.Contains("weapon") || cont.Contains("border")) { report.Classification = Classification.Secret; return; }

            if (report.Priority == Priority.Medium) { report.Classification = Classification.Restricted; return; }
            if (report.GetSourceType() == "Soldier") { report.Classification = Classification.Restricted; return; }

            report.Classification = Classification.Unclassified; return;
        }
    }
}