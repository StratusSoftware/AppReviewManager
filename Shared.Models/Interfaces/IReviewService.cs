using AppReview.Shared.Models.Review;

namespace AppReview.Shared.Models.Interfaces;

public interface IReviewService
{
    Task<ReviewResponse> GetReviewsAsync(string packageName);

    Task<Models.Review.Review> GetReviewByIdAsync(string reviewId);
}
