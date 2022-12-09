using AppReview.Shared.Models.Interfaces;
using AppReview.Shared.Models.Review;

namespace AppReviewManager.Services;

/// <summary>
/// Concrete implementation of the IReviewService
/// </summary>
public class ReviewService : IReviewService
{
    private readonly ILogger<ReviewService> _logger;
    private readonly HttpClient _httpClient;

    private const string LIST_REVIEW_ENDPOINT = "AndroidPublisher/v3/applications/reviews?packageName={0}";
    private const string GET_REVIEW_ENDPOINT = "AndroidPublisher/v3/applications/reviews/{0}";

    public ReviewService(ILogger<ReviewService> logger, HttpClient httpClient)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    public async Task<ReviewResponse> GetReviewsAsync(string packageName)
    {
        var result = await _httpClient.GetAsync(string.Format(LIST_REVIEW_ENDPOINT, packageName));

        if (!result.IsSuccessStatusCode)
        {
            _logger.LogInformation($"No reviews found for {packageName}");
            return new ReviewResponse();
        }

        return await result.Content.ReadFromJsonAsync<ReviewResponse>();
    }

    public async Task<Review> GetReviewByIdAsync(string reviewId)
    {
        var result = await _httpClient.GetAsync(string.Format(GET_REVIEW_ENDPOINT, reviewId));

        if (!result.IsSuccessStatusCode)
        {
            _logger.LogInformation($"No reviews found for {reviewId}");
            return null;
        }

        return await result.Content.ReadFromJsonAsync<Review>();
    }
}