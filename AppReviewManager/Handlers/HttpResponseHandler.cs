using Radzen;

namespace AppReviewManager.Handlers;

public class HttpResponseHandler : DelegatingHandler
{
    private readonly NotificationService _notificationService;

    public HttpResponseHandler(NotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
    {
        try
        {
            var response = await base.SendAsync(request, cancellationToken);

            switch (response.StatusCode)
            {
                case System.Net.HttpStatusCode.InternalServerError:
                    _notificationService.Notify(NotificationSeverity.Error, "An error occurred, Please try again.");
                    break;
                case System.Net.HttpStatusCode.NotFound:
                    _notificationService.Notify(NotificationSeverity.Warning, "Record not found.");
                    break;
                case System.Net.HttpStatusCode.Forbidden:
                    _notificationService.Notify(NotificationSeverity.Warning, "Access Denied");
                    break;
            }

            return response;
        }
        catch (System.Net.Http.HttpRequestException ex)
        {
            _notificationService.Notify(NotificationSeverity.Error, ex.Message);
            return new HttpResponseMessage(System.Net.HttpStatusCode.BadGateway);
        }
    }
}
