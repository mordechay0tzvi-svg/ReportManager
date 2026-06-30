using IntelligencePipeline.Models.Enums;
namespace IntelligencePipeline.Models.Reports
{
    class SoldierReport : Report
    {
        private string _soldierName;
        private string _soldierID;
        private string _unit;
        private int _confidenceLevel;

        string SoldierName { get; set; }
        string SoldierID { get; set; } 
        string Unit { get; set; } 
        int ConfidenceLevel { get; set; }

        public SoldierReport(int reportId, DateTime timestamp, double latitude, double longitude, string description, string soldierName, string soldierID, string unit, int confidenceLevel) : base(reportId, timestamp, latitude, longitude, description)
        {

        }

        public override string GetSourceType() =>; "Soldier";
        public override int CalculateReliabilityScore() { }
    }
}