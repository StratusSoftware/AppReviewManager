namespace mock.androidpublisher.googleapis.com.Data;
public static class SeedManager
{
    public static WebApplication SeedData(this WebApplication webApp)
    {
        using (var scope = webApp.Services.CreateScope())
        {
            using (var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>())
            {
                    var seedHelper = scope.ServiceProvider.GetRequiredService<SeedHelper>();
                    seedHelper.SeedData(context);
            }
        }
        return webApp;
    }
}
