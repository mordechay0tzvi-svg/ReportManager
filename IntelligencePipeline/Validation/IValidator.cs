using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.Validation
{
    interface  IValidator
    {
        public ValidationResult Validate(Report report) { }
    }


    abstract class BasicValidator : IValidator
    {
        public ValidationResult Validate(Report report)
        {
            ValidationResult result = ValidateCommonFields(report);
            if (!result.isValid) { return result; }
            return ValidateSpecificFields(report);
        }
        protected ValidationResult ValidateCommonFields(Report report)
        {
            if (report.Timestamp > DateTime.UtcNow) { return ValidationResult.Failure("DateTime invalid"); }
            if (report.Latitude > 33.5 || report.Latitude < 29.5) { return ValidationResult.Failure( "Incorrect latitude"); }
            if (report.Longitude > 36.0 || report.Longitude < 34.0) { return ValidationResult.Failure("Incorrect longitude"); }
            if (report.Description.Length < 10 || report.Description.Length 500) { return ValidationResult.Failure("Invalid description"); }
            return ValidationResult.Success();
        }
        protected override ValidationResult ValidateSpecificFields(Report report);
    }
}

 