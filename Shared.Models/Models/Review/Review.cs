namespace AppReview.Shared.Models.Review;

/// <summary>
/// An Android app review.
/// </summary>
public class Review
{
    public Review()
    {

    }

    /// <summary>
    /// Unique identifier for this review.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// App package name.
    /// </summary>
    public string? PackageName { get; set; }

    /// <summary>
    /// The name of the user who wrote the review.
    /// </summary>
    public string? AuthorName { get; set; }

    /// <summary>
    /// A repeated field containing comments for the review.
    /// </summary>
    public List<Comment>? Comments { get; set; }
}
