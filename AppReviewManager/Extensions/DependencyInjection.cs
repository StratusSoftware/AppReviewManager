using AppReviewManager.Configuration;
using AppReviewManager.Handlers;
using AppReviewManager.Services;
using Radzen;

namespace AppReviewManager.Data;

public static class DependencyInjection
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        var appsettings = builder.Configuration.GetSection("Configuration").Get<AppSettings>();

        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();

        builder.Services.AddScoped<HttpResponseHandler>();
        builder.Services.AddSingleton<ReviewService>();
        builder.Services.AddScoped<DialogService>();
        builder.Services.AddScoped<NotificationService>();

        builder.Services.AddHttpClient("GoogleApi", client => client.BaseAddress = new(appsettings.GoogleApiUrl))
            .ConfigureHttpMessageHandlerBuilder(builder =>
            {
                builder.AdditionalHandlers.Add(builder.Services.GetRequiredService<HttpResponseHandler>());
            });

        builder.Services.AddSingleton(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("GoogleApi"));

        return builder.Build();
    }
}