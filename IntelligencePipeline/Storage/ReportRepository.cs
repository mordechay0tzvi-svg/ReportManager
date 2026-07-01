using IntelligencePipeline.Models.Reports
namespace IntelligencePipeline.Storage
{
    private List<Report> _reports;
    public ReportRepository() 
    {
        _reports = new List<Report>;
    }
    public void Add(Report report) { }
    public List<Report> GetAll() { }
    public List<Report> GetByStatus(ReportStatus status) { }
    public List<Report> GetByPriority(Priority priority) { }
    public List<Report> Search(string keyword) { }
    public Report GetById(int reportId) { }
    public void UpdateStatus(int reportId, ReportStatus newStatus) { }
    public int GetTotalCount() { }
    public int GetCountByStatus(ReportStatus status) { }
    }