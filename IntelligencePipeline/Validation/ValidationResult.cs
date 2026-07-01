using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.Validation
{
    class ValidationResult : IValidator
    {
        public bool IsValid { get; }
        public string ErrorMessage { get; }

        public ValidationResult(bool isValid, string errorMessage) 
        {
            IsValid = isValid;
            ErrorMessage = errorMessage;
        }
        public static ValidationResult Success() 
        {
            return new ValidationResult(true, " ");
        }
        public static ValidationResult Failure(string errorMessage)
        {
            return new ValidationResult(false, errorMessage);
        }
    }
}
