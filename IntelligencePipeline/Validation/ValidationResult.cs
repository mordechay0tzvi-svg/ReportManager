using IntelligencePipeline.Models.Enums;
namespace IntelligencePipeline.Validation
{
    class ValidationResult : IValidator
    {
        private bool _isValid;
        private string _errorMessage;

        bool IsValid { get; }
        string ErrorMessage { get; }

        public ValidationResult(bool isValid, string errorMessage) { }
        public static ValidationResult Success() { }
        public static ValidationResult Failure(string errorMessage) { }
    }
}