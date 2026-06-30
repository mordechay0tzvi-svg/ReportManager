using IntelligencePipeline.Models.Enums;
namespace IntelligencePipeline.Validation
{
    interface  IValidator
    {
        public ValidationResult Validate(Report report) { }
    }
}