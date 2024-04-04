using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.ClientFeedbacks;
using Promact.CustomerSuccess.Platform.Services.Dtos.ApprovedTeams;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services.ApprovedTeams
{

    public class ApprovedTeamService :
          CrudAppService<ApprovedTeam,
          ApprovedTeamDto,
          Guid,
          PagedAndSortedResultRequestDto, 
          CreateApprovedTeamDto, 
          UpdateApprovedTeamDto>,
          IApprovedTeamService
         {
          public ApprovedTeamService(IRepository<ApprovedTeam, Guid> repository) : base(repository)
            {
            }
        }
    
}
