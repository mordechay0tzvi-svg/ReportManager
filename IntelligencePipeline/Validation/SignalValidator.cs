using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.Validation
{
    class SignalValidator : BasicValidator
    {
        protected override ValidationResult? ValidateSpecificFields(Report report)
        {
            if (report is SignalReport signal) {  
            if (signal.Frequency > 3000.0 || signal.Frequency < 1.0) { return ValidationResult.Failure("Invalid frequency"); }
            if (signal.Content.Length > 1000 || signal.Content.Length < 0) { return ValidationResult.Failure("Invalid content"); }
            if (signal.SignalStrength > 0 || signal.SignalStrength < -120) { return ValidationResult.Failure("Invalid signal strength"); }
            return ValidationResult.Success();}
            return null;
        }
    }
}
