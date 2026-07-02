using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.Storage
{
    class RejectedReportRepository
    {
        private List<Report> _rejectedReports;
        public RejectedReportRepository()
        {
            new List<Report>();
        }
        public void Add(Report report) { }
        public List<Report> GetAll() { }
        public int GetTotalCount() { }
        public List<Report> GetByReason(string reasonKeyword) { }
    }
}