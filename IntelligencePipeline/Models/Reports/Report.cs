using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Calculators;
namespace IntelligencePipeline.Models.Reports
{
    abstract class Report
    {
        private int _reportId;
        private DateTime _timestamp;
        private double _latitude; 
        private double _longitude;
        private string _description;
        private ReportStatus _status;
        private Priority _priority;
        private Classification _classification;
        private int _reliabilityScore;
        private string _rejectionReason;

        public int ReportId { get { => _reportId; } }
        public DateTime Timestamp { get { => _timestamp; } set { _timestamp = value; } }
        public double Latitude { get { => _latitude; } set { _latitude = value; }
        public double Longitude { get { => _longitude; } set{ _longitude = value; } }
        public string Description { get { => _description; } set { _description = value; } }
        public ReportStatus Status { get { => _status; } set { _status = value; } }
        public Priority Priority { get { => _priority; } set { _priority = value; } }
        public Classification Classification { get { => _classification; } set { _classification = value; } }
        public int ReliabilityScore { get { => _reliabilityScore; } set { _reliabilityScore = value; } }
        public string RejectionReason { get { => _rejectionReason; } set { _rejectionReason = value; } }

        protected Report(int reportId, DateTime timestamp, double latitude, double longitude, string description) 
        {
            ReportId = reportId;
            Timestamp = timestamp;
            Latitude = latitude;
            Longitude = longitude;
            Description = description;
            Status = ReportStatus.New;
            Priority; // ?
            Classification; // ?
            ReliabilityScore; //?
            RejectionReason = " ";
        }

        public abstract string GetSourceType();
        public abstract int CalculateReliabilityScore();
        public virtual string GetSummary() { }
        public override string ToString() { }
    } 
}

