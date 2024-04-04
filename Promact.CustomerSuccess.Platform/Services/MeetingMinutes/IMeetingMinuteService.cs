using Volo.Abp.Application.Services;

namespace Promact.CustomerSuccess.Platform.Services.MeetingMinutes
{
    /// <summary>
    /// This interface defines the contract for meeting minute-related operations.
    /// Implement this interface to provide functionality for managing meeting minutes.
    /// </summary>
    public interface IMeetingMinuteService : IApplicationService
    {
        // we can add method declarations for meeting minute operations here.
        // For example:
        // Task<MeetingMinuteDto> CreateMeetingMinuteAsync(CreateMeetingMinuteDto input);
        // Task<MeetingMinuteDto> GetMeetingMinuteAsync(Guid id);
        // Task UpdateMeetingMinuteAsync(UpdateMeetingMinuteDto input);
        // Task DeleteMeetingMinuteAsync(Guid id);
    }
}
