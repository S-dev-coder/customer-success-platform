using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos.MeetingMinutes;
using Promact.CustomerSuccess.Platform.Services.ProjectResources;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services.MeetingMinutes
{
    public class MeetingMinuteService :
      CrudAppService<MeetingMinute,
         MeetingMinuteDto,
          Guid,
          PagedAndSortedResultRequestDto,
          CreateMeetingMinuteDto,
          UpdateMeetingMinuteDto>,
      IProjectResourceService
    {
        public MeetingMinuteService(IRepository<MeetingMinute, Guid> repository) : base(repository)
        {

        }
    }
}
