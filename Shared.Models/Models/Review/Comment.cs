namespace AppReview.Shared.Models.Review;

/// <summary>
/// User entry from conversation between user and developer.
/// </summary>
public class Comment
{
    /// <summary>
    /// The Id of the Comment.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The Id of the parent Review.
    /// </summary>
    public Guid ReviewId { get; set; }

    /// <summary>
    /// The content of the comment, i.e. review body. 
    /// In some cases users have been able to write a review with separate title and body; in those cases the title and body are concatenated and separated by a tab character.
    /// </summary>
    public string? Text { get; set; }

    /// <summary>
    /// The star rating associated with the review, from 1 to 5.
    /// </summary>
    public int StarRating { get; set; }

    /// <summary>
    /// Language code for the reviewer. This is taken from the device settings so is not guaranteed to match the language the review is written in. May be absent.
    /// </summary>
    public string? ReviewerLanguage { get; set; }

    /// <summary>
    /// Codename for the reviewer's device, e.g. klte, flounder. May be absent.
    /// </summary>
    public string? Device { get; set; }

    /// <summary>
    /// Integer Android SDK version of the user's device at the time the review was written, e.g. 23 is Marshmallow. May be absent.
    /// </summary>
    public int AndroidOsVersion { get; set; }

    /// <summary>
    /// Integer version code of the app as installed at the time the review was written. May be absent.
    /// </summary>
    public int AppVersionCode { get; set; }

    /// <summary>
    /// String version name of the app as installed at the time the review was written. May be absent.
    /// </summary>
    public string? AppVersionName { get; set; }

    /// <summary>
    /// Number of users who have given this review a thumbs up.
    /// </summary>
    public int ThumbsUpCount { get; set; }

    /// <summary>
    /// Number of users who have given this review a thumbs down.
    /// </summary>
    public int ThumbsDownCount { get; set; }

    /// <summary>
    /// Information about the characteristics of the user's device.
    /// </summary>
    public DevicemetaData? DeviceMetadata { get; set; }

    /// <summary>
    /// Untranslated text of the review, where the review was translated. If the review was not translated this is left blank.
    /// </summary>
    public string? OriginalText { get; set; }
}

/// <summary>
/// Characteristics of the user's device.
/// </summary>
public class DevicemetaData
{
    /// <summary>
    /// The Id of the DevicemetaData.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The parent Id of the comment.
    /// </summary>
    public Guid CommentId { get; set; }

    /// <summary>
    /// Device model name (e.g. Droid)
    /// </summary>
    public string? ProductName { get; set; }

    /// <summary>
    /// Device manufacturer (e.g. Motorola)
    /// </summary>
    public string? Manufacturer { get; set; }

    /// <summary>
    /// Device class (e.g. tablet)
    /// </summary>
    public string? DeviceClass { get; set; }

    /// <summary>
    /// Screen width in pixels
    /// </summary>
    public int ScreenWidthPx { get; set; }

    /// <summary>
    /// Screen height in pixels
    /// </summary>
    public int ScreenHeightPx { get; set; }

    /// <summary>
    /// Comma separated list of native platforms (e.g. "arm", "arm7")
    /// </summary>
    public string? NativePlatform { get; set; }

    /// <summary>
    /// Screen density in DPI
    /// </summary>
    public int ScreenDensityDpi { get; set; }

    /// <summary>
    /// OpenGL version
    /// </summary>
    public int GlEsVersion { get; set; }

    /// <summary>
    /// Device CPU model, e.g. "MSM8974"
    /// </summary>
    public string? CpuModel { get; set; }

    /// <summary>
    /// Device CPU make, e.g. "Qualcomm"
    /// </summary>
    public string? CpuMake { get; set; }

    /// <summary>
    /// Device RAM in Megabytes, e.g. "2048"
    /// </summary>
    public int RamMb { get; set; }
}

