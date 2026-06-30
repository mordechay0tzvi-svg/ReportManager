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

        int ReportId { get; }
        DateTime Timestamp { get; set; }
        double Latitude { get; set; }
        double Longitude { get; set; }
        string Description { get; set; }
        ReportStatus Status { get; set; }
        Priority Priority { get; set; }
        Classification Classification { get; set; }
        int ReliabilityScore { get; set; }
        string RejectionReason { get; set; }

        protected Report(int reportId, DateTime timestamp, double latitude, double longitude, string description) { }
        public abstract string GetSourceType();
        public abstract int CalculateReliabilityScore();
        public virtual string GetSummary() { }
        public override string ToString() { }

    } 
}

