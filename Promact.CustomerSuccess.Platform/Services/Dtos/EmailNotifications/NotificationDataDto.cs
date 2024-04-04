using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.EmailNotifications
{
    public class NotificationDataDto 
    {
        public required string Subject { get; set; }
        public required string Message { get; set; }
    }
}
