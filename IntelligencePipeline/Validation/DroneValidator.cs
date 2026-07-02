using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.Validation
{
    class DroneValidator : BasicValidator
    {
        protected override ValidationResult ValidateSpecificFields(Report report)
        {
            if (report is DroneReport drone){  
            if (drone.Altitude > 10000 || drone.Altitude < 100) { return ValidationResult.Failure("Invalid altitude"); }
            if (drone.ImageQuality > 100 || drone.ImageQuality < 1) { return ValidationResult.Failure("Invalid quality"); }
            return ValidationResult.Success();}
        }
    }
}