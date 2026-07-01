using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.Validation
{
    class SignalValidator : BasicValidator
    {
        protected override ValidationResult ValidateSpecificFields(Report report)
        {
            if (!report is SignalReport) { return ValidationResult.Failure("Wrong type"); }
            if (report.Frequency: > 3000.0 || report.Frequency: < 1.0)) { return ValidationResult.Failure("Invalid frequency"); }
            if (report.Content.Length > 1000 || report.Content.Length < 0)) { return ValidationResult.Failure("Invalid content"); }
            if (!Enum.TryParse<Language>(report.Language, out Language _) { return ValidationResult.Failure("Language is inacceptable"); } 
            if (report.SignalStrength > 0 || report.SignalStrength < -120)) { return ValidationResult.Failure("Invalid signal strength"); }
            return ValidationResult.Success();
        }

    }
}