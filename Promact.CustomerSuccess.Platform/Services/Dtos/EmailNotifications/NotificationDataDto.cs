using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.EmailNotifications
{
    public class NotificationDataDto 
    {
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
