namespace AppReview.Shared.Models.Common;

/// <summary>
/// Information about the current page.
/// </summary>
public class PageInfo
{
    /// <summary>
    /// Total number of results available on the backend ! The total number of results in the result set.
    /// </summary>
    public int TotalResults { get; set; }

    /// <summary>
    /// Maximum number of results returned in one page. ! The number of results included in the API response.
    /// </summary>
    public int ResultPerPage { get; set; }

    /// <summary>
    /// Index of the first result returned in the current page.
    /// </summary>
    public int StartIndex { get; set; }
}
