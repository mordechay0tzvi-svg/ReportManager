using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.Validation
{
    class RadarValidator : BasicValidator
    {
        protected override ValidationResult ValidateSpecificFields(Report report)
        {
            if (report is RadarReport radar) { 
            if (radar.Speed > 2000 || radar.Speed < 0) { return ValidationResult.Failure("Invalid speed"); }
            if (radar.Direction > 360 || radar.Direction < 0) { return ValidationResult.Failure("Invalid direction"); }
            if (radar.Distance > 100000 || radar.Distance < 100) { return ValidationResult.Failure("Invalid distance"); }
            return ValidationResult.Success();}
        }
    }
}

