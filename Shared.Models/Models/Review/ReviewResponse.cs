using AppReview.Shared.Models.Common;

namespace AppReview.Shared.Models.Review;

/// <summary>
/// Response listing reviews.
/// </summary>
public class ReviewResponse
{
    public ReviewResponse()
    {

    }

    /// <summary>
    /// apks.list of reviews.
    /// </summary>
    public List<Review>? Reviews { get; set; }

    /// <summary>
    /// Information about the current page.
    /// </summary>
    public PageInfo? PageInfo { get; set; }
}