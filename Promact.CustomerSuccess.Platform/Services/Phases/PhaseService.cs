using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos.Phases;
using Promact.CustomerSuccess.Platform.Services.ProjectResources;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services.Phases
{

    public class PhaseService :
     CrudAppService<Phase,
        PhaseDto,
         Guid,
         PagedAndSortedResultRequestDto,
         CreatePhaseDto,
         UpdatePhaseDto>,
     IPhaseService
        {
            public PhaseService(IRepository<Phase, Guid> repository) : base(repository)
            {

            }
        }
    
}
