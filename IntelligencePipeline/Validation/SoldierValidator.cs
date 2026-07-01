using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;
using IntelligencePipeline.Validation;
namespace IntelligencePipeline.Validation
{
    class SoldierValidator : BasicValidator
    {
        protected override ValidationResult ValidateSpecificFields(Report report)
        {
            if (report is not SoldierReport) { return ValidationResult.Failure("Wrong type"); }
            if (report.SoldierNmae.Length > 50 || report.SoldierNmae.Length < 2) { return ValidationResult.Failure("Bad soldier name"); }
            if (!int.TryParse(report.SoldierId, out int _) || report.SoldierId.Length > 7 ) { return ValidationResult.Failure("Invalid id"); }
            if (report.Unit.Length > 50 || report.Unit.Length < 2) { return ValidationResult.Failure("Bad unit name"); }
            if (report.ConfidenceLevel > 5 || report.ConfidenceLevel < 1) { return ValidationResult.Failure("Invalid level"); }
            return ValidationResult.Success();
        }
    }
}
