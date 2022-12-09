using Microsoft.AspNetCore.Mvc;
using AppReview.Shared.Models.Interfaces;
using AppReview.Shared.Models.Review;

namespace mock.androidpublisher.googleapis.com.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AndroidPublisherController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public AndroidPublisherController(ILogger<AndroidPublisherController> logger, IReviewService reviewService)
        {
            _reviewService = reviewService ?? throw new ArgumentNullException(nameof(reviewService));
        }

        /// <summary>
        /// Lists all reviews.
        /// </summary>
        /// <response code="200">The request was processed correctly.</response>
        /// <param name="packageName">Package name of the app.</param>
        /// <returns>A <see cref="ReviewResponse"/> containing the returned reviews.</returns>
        [HttpGet("v3/applications/reviews")]
        public async Task<IActionResult> List([FromQuery] string packageName)
        {
            return new OkObjectResult(await _reviewService.GetReviewsAsync(packageName));
        }

        /// <summary>
        /// Get review by Id.
        /// </summary>
        /// <response code="200">The request was processed correctly.</response>
        /// <param name="reviewId">Id of the review.</param>
        /// <returns>A <see cref="Review"/> containing the review.</returns>
        [HttpGet("v3/applications/reviews/{reviewId}")]
        public async Task<IActionResult> GetById([FromRoute] string reviewId)
        {
            var review = await _reviewService.GetReviewByIdAsync(reviewId);

            if (review is null)
            {
                return NotFound();
            }

            return new OkObjectResult(review);
        }
    }
}