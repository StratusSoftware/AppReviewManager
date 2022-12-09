using FluentValidation;
using AppReview.Shared.Models.Review;
using AppReview.Shared.Models.Enums;

namespace AppReviewManager.Models.Validators;
public class ReviewReportValidator : AbstractValidator<ReviewReport>
{
    public ReviewReportValidator()
    {
        RuleSet("Reasons", () =>
        {
            RuleFor(p => p.Notes)
            .NotEmpty()
            .WithMessage("You must enter Notes for this reason type.")
            .When(p => p.Reason == ReasonType.Offensive)
            .MinimumLength(10).WithMessage("Notes must be more than 10 chars.");
        });
    }
}
