using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.Validation
{
    class DroneValidator : BasicValidator
    {
        protected override ValidationResult ValidateSpecificFields(Report report)
        { 
            if (!report is DroneReport) { return ValidationResult.Failure("Wrong type"); }
            if (report.Altitude > 10000 || report.Altitude < 100) { return ValidationResult.Failure("Invalid altitude"); }
            if (report.ImageQuality > 100 || report.ImageQuality < 1) { return ValidationResult.Failure("Invalid quality"); }
            return ValidationResult.Success();
        }
    }
}