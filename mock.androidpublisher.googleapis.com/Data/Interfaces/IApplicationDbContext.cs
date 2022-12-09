using Microsoft.EntityFrameworkCore;
using AppReview.Shared.Models.Review;

namespace mock.androidpublisher.googleapis.com.Data.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Review> Reviews { get; }
}
