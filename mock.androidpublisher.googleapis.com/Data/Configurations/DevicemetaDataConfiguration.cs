using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppReview.Shared.Models.Review;

namespace mock.androidpublisher.googleapis.com.Data.Configurations;

public class DevicemetaDataConfiguration : IEntityTypeConfiguration<DevicemetaData>
{
    public void Configure(EntityTypeBuilder<DevicemetaData> builder)
    {

    }
}