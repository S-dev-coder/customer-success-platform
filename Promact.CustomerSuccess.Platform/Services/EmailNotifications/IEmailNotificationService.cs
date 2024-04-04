using Promact.CustomerSuccess.Platform.Services.Dtos.EmailNotifications;
using Volo.Abp.Application.Services;

namespace Promact.CustomerSuccess.Platform.Services.EmailNotifications
{
    public interface IEmailNotificationService
    {
        Task SendNotificationAsync(string email, NotificationDataDto input);
        Task SendNotificationAsync(List<string> emailList, NotificationDataDto input);
        Task SandNotificationsToStakeHolders(Guid projectId, NotificationDataDto input);
    }

}
