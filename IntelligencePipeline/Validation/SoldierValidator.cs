using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.Validation
{
    class SoldierValidator : BasicValidator
    {
        protected override ValidationResult? ValidateSpecificFields(Report report)
        {
            if (report is SoldierReport soldier) { 
            if (soldier.SoldierName.Length > 50 || soldier.SoldierName.Length < 2) {return ValidationResult.Failure("Bad soldier name"); }
            if (!int.TryParse(soldier.SoldierID, out int _) || soldier.SoldierID.Length > 7 ) { return ValidationResult.Failure("Invalid id"); }
            if (soldier.Unit.Length > 50 || soldier.Unit.Length < 2) {return ValidationResult.Failure("Bad unit name"); }
            if (soldier.ConfidenceLevel > 5 || soldier.ConfidenceLevel < 1) {return ValidationResult.Failure("Invalid level"); }
            return ValidationResult.Success();}
            return null;
        }
    }
}
