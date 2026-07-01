using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.Validation
{
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
            
        }
        protected override ValidationResult ValidateSpecificFields(Report report);
    }
}