abstract class BasicReport
{
    protected string _sourcetype;
    public string SourceType { get; set; }
    protected DateTime _timestamp; 
    public DateTime TimeStamp { get; set; }
    protected double _latitude;
    public double Latitude { get; set; }
    protected double _longitude;
    public double Longitude { get; set; }
    protected string _description;
    public string Description { get; set; }


    public static int ReportId;
    public string status { get { } }
    public string Priority { get { } }
    public string Classification { get { } }
    public int ReliabilityScore { get { } }
    public string RejectionReason { get { } }
}

class DroneReport : BasicReport
{
    public int Altitude;
    public int ImageQuality;
}

class SoldierReport : BasicReport
{
    public string SoldierName;
    public string SoldierID;
    public string Unit;
    public int ConfidenceLevel;
}

class RadarReport : BasicReport
{
    public int Speed;
    public int Direction;
    public int Distance;
}

class SignalReport : BasicReport
{
    public double Frequency;
    public string Content;
    public string Language;
    public int SignalStrength;
}
