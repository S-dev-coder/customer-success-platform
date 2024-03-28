using Promact.CustomerSuccess.Platform.Services.Dtos.ProjectBudgets;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Promact.CustomerSuccess.Platform.Entities;
using AutoMapper;

namespace Promact.CustomerSuccess.Platform.Services.ProjectBudgets
{
    public class ProjectBudgetService :
         CrudAppService<ProjectBudget, ProjectBudgetDto, Guid, PagedAndSortedResultRequestDto, CreateProjectBudgetDto, UpdateProjectBudgetDto>,
         IProjectBudgetService
    {
        private readonly IMapper _mapper;
        public ProjectBudgetService(IRepository<ProjectBudget, Guid> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        // get all by project id and date
        public async Task<List<ProjectBudgetDto>> GetByProjectId(Guid projectId)
        {
            var projectBudgets = await Repository.GetListAsync(x => x.ProjectId == projectId);
            return _mapper.Map<List<ProjectBudgetDto>>(projectBudgets);
        }
    }
}
