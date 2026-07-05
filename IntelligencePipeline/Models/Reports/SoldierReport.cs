using IntelligencePipeline.Models.Enums;
namespace IntelligencePipeline.Models.Reports
{
    class SoldierReport : Report
    {
        public string SoldierName { get; protected set; }
        public string SoldierID { get; protected set; }
        public string Unit { get; protected set; }
        public int ConfidenceLevel { get; protected set; }

        public SoldierReport(DateTime timestamp, double latitude, double longitude, string description, string soldierName, string soldierID, string unit, int confidenceLevel) : base(timestamp, latitude, longitude, description)
        {
            SoldierName = soldierName;
            SoldierID = soldierID;
            Unit = unit;
            ConfidenceLevel = confidenceLevel;
        }

        public override string GetSourceType() => "Soldier";
        public override int CalculateReliabilityScore() 
        {
            int score = 4;
            score += ConfidenceLevel;
            string desc = Description.ToLower();
            if (desc.Contains("weapon") || desc.Contains("vehicle") || desc.Contains("movement") || desc.Contains("explosion")) {score += 1;}
            if (score > 10) { score = 10;}
            return score;
        }
    }
}