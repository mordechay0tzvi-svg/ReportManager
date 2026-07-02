using IntelligencePipeline.Calculators;
using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;
using IntelligencePipeline.Storage;
using IntelligencePipeline.Validation;
namespace IntelligencePipeline.Pipeline
{
    class ReportPipeline
    {

        private ReportRepository _validatedReports;
        private RejectedReportRepository _rejectedReports;
        private int _nextReportId;
        public ReportPipeline()
        {
            _nextReportId = 0;
            _validatedReports = new ReportRepository();
            _rejectedReports = new RejectedReportRepository();
        }
        public void ProcessReport(Report report) 
        {
            report.Status = ReportStatus.Validating;
            ValidateReport(report);
            if (report.Status == ReportStatus.Validated)
            {
                ReliabilityCalculator rb = new ReliabilityCalculator();
                report.ReliabilityScore = rb.Calculate(report);
                PriorityCalculator pr = new PriorityCalculator();
                report.Priority = pr.Calculate(report);
                ClassificationCalculator cc = new ClassificationCalculator();
                report.Classification = cc.Calculate(report);
            }
            StoreReport(report);
            return;
        }
        public ReportRepository GetValidatedReports() 
        {
            return _validatedReports;
        }
        public RejectedReportRepository GetRejectedReports() 
        {
            return _rejectedReports;
        }
        public void DisplayStatistics() 
        {
            //
        }
        private IValidator? GetValidator(Report report) 
        {
            string type = report.GetSourceType();
            switch (type)
            {
                case "Drone":
                    return new DroneValidator();
                case "Radar":
                    return new RadarValidator();
                case "Soldier":
                    return new SoldierValidator();
                case "Signal":
                    return new SignalValidator();
            }
            return null;
        }
        private void ValidateReport(Report report) 
        {
            IValidator? vld = GetValidator(report);
            if (vld == null) { return; }
            ValidationResult result = vld.Validate(report);

            if (!result.IsValid) 
            { 
                report.Status = ReportStatus.Rejected;
                report.RejectionReason = result.ErrorMessage;
                return;
            }
            else
            {
                report.Status = ReportStatus.Validated;
                return;
            }
        }
        private void CalculateMetrics(Report report) 
        { 
            //
        }
        private void StoreReport(Report report) 
        {
            if (report.Status == ReportStatus.Validated) { _validatedReports.Add(report); }
            else if (report.Status == ReportStatus.Rejected) { _rejectedReports.Add(report); }
        }
    }
}
