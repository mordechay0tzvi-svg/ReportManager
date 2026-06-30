abstract class BasicReport
{
    protected string _sourcetype;
    public string SourceType { get; set { } }
    protected DateTime _timestamp; 
    public DateTime TimeStamp { get; set { } }
    protected double _latitude;
    public double Latitude { get; set { } }
    protected double _longitude;
    public double Longitude { get; set { } }
    protected string _description;
    public string Description { get; set { } }


    public static int ReportId;
    public string status { get { } }
    public string Priority { get { } }
    public string Classification { get { } }
    public int ReliabilityScore { get { } }
    public string RejectionReason { get { } }
}

class DroneReport : BasicReport
{
    protected int _altitude;
    public int Altitude { get; set { } }
    protected int _imageQuality;
    public int ImageQuality { get; set { } }
}

class SoldierReport : BasicReport
{
    protected string _soldierName;
    public string SoldierName { get; set { } }
    protected string _soldierID;
    public string SoldierID { get; set { } }
    protected string _unit;
    public string Unit { get; set { } }
    protected int _confidenceLevel;
    public int ConfidenceLevel { get; set { } }
}

class RadarReport : BasicReport
{
    protected int _speed;
    public int Speed { get; set { } }
    protected int _direction;
    public int Direction { get; set { } }
    protected int _distance;
    public int Distance { get; set { } }
}

class SignalReport : BasicReport
{
    protected double _frequency;
    public double Frequency { get; set { } }
    protected string _content;
    public string Content { get; set { } }
    protected string _language;
    public string Language { get; set { } }
    protected int _signalStrength;
    public int SignalStrength { get; set { } }
}

