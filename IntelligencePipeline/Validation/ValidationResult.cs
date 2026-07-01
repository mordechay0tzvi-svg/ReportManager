using IntelligencePipeline.Models.Enums;
namespace IntelligencePipeline.Validation
{
    class ValidationResult : IValidator
    {
        private bool IsValid;
        private string ErrorMessage;

        bool IsValid { get; }
        string ErrorMessage { get; }

        public ValidationResult(bool isValid, string errorMessage) 
        {
            IsValid = isValid;
            ErrorMessage = errorMessage;
        }
        public static ValidationResult Success() 
        {
            return new ValidationResult(true, ErrorMessage);
        }
        public static ValidationResult Failure(string errorMessage)
        {
            return new ValidationResult(false, ErrorMessage);
        }
    }
}