using AppReview.Shared.Models.Review;
using AppReview.Shared.Models.Interfaces;
using mock.androidpublisher.googleapis.com.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace mock.androidpublisher.googleapis.com.Services;

/// <summary>
/// Concrete implementation of the IReviewService
/// </summary>
public class ReviewService : IReviewService
{
    private readonly ILogger<ReviewService> _logger;
    private readonly IApplicationDbContext _context;

    private const string LIST_REVIEW_ENDPOINT = "AndroidPublisher/v3/applications/{0}/reviews";

    public ReviewService(ILogger<ReviewService> logger, IApplicationDbContext context)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<ReviewResponse> GetReviewsAsync(string packageName)
    {
        var reviewResponse = new ReviewResponse
        {
            Reviews = _context.Reviews.Include(r => r.Comments).ThenInclude(c => c.DeviceMetadata).Where(r => r.PackageName == packageName).ToList(),
        };

        //mock the page info for testing
        reviewResponse.PageInfo = new AppReview.Shared.Models.Common.PageInfo
        {
            TotalResults = reviewResponse.Reviews.Count(),
            ResultPerPage = 1000,
            StartIndex = 0,
        };

        return reviewResponse;
    }

    public async Task<Review> GetReviewByIdAsync(string reviewId)
    {
        return await _context.Reviews.FindAsync(reviewId);
    }
}