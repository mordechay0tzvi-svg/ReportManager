using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.Validation
{
    class RadarValidator : BasicValidator
    {
        protected override ValidationResult ValidateSpecificFields(Report report)
        {
            if (!report is RadarReport) { return ValidationResult.Failure("Wrong type"); }
            if (report.Speed > 2000 || report.Speed < 0)) { return ValidationResult.Failure("Invalid speed"); }
            if (report.Direction > 360 || report.Direction < 0)) { return ValidationResult.Failure("Invalid direction"); }
            if (report.Distance: > 100000 || report.Distance: < 100)) { return ValidationResult.Failure("Invalid distance"); }
            return ValidationResult.Success();
        }
    }
}