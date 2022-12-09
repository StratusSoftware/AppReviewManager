using AppReview.Shared.Models.Enums;

namespace AppReview.Shared.Models.Review;

public class ReviewReport
{
    public string? Notes { get; set; }

    public ReasonType? Reason { get; set; }

}
