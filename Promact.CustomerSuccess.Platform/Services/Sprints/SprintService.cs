using AutoMapper;
using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos.Sprints;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services.Sprints
{
    public class SprintService: CrudAppService<Sprint,SprintDto,Guid, PagedAndSortedResultRequestDto, CreateSprintDto, UpdateSprintDto>, ISprintService
    {
        private readonly IMapper _mapper;

        public SprintService(IRepository<Sprint, Guid> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        // get all sprints by project id
        public async Task<List<SprintDto>> GetByProjectIdAsync(Guid projectId)
        {
            var sprints = await Repository.GetListAsync(x => x.PhaseMilestone.ProjectId == projectId);
            return _mapper.Map<List<SprintDto>>(sprints);
        }

        // get sprint by phase milestone id
        public async Task<SprintDto> GetByPhaseMilestoneIdAsync(Guid phaseMilestoneId)
        {
            var sprint = await Repository.FirstOrDefaultAsync(x => x.PhaseMilestoneId == phaseMilestoneId);
            return _mapper.Map<SprintDto>(sprint);
        }
    }
}
