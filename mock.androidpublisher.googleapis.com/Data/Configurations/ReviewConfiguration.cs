using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppReview.Shared.Models.Review;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System;

namespace mock.androidpublisher.googleapis.com.Data.Configurations;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.HasMany(r => r.Comments)
                .WithOne();

    }
}