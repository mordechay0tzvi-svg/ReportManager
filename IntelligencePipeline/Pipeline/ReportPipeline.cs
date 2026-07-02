using IntelligencePipeline.Calculators;
using IntelligencePipeline.Models;
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
        }
        public void ProcessReport(Report report) { }
        public ReportRepository GetValidatedReports() { }
        public RejectedReportRepository GetRejectedReports() { }
        public void DisplayStatistics() { }

        private IValidator GetValidator(Report report) { }
        private void ValidateReport(Report report) { }
        private void CalculateMetrics(Report report) { }
        private void StoreReport(Report report) { }
    }
}