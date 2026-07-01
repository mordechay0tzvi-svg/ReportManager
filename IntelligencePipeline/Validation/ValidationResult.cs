using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.Validation
{
    class ValidationResult : IValidator
    {
        private bool _isvalid;
        private string _errormessage;

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
