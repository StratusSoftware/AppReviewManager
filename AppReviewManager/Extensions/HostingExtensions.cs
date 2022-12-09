using AppReviewManager.Models.Validators;
using FluentValidation;
using AppReview.Shared.Models.Review;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods for IServiceCollection to register our custom services
    /// </summary>
    public static class HostingExtensions
    {
        public static IServiceCollection AddFluentValidators(this IServiceCollection services)
        {
            services.AddTransient<IValidator<ReviewReport>, ReviewReportValidator>();

            return services;
        }       

    }
}