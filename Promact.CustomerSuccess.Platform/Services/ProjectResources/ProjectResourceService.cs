using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos.ProjectResources;
using Promact.CustomerSuccess.Platform.Services.ProjectResources;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services.ProjectResources
{
    public class ProjectResourceService :
       CrudAppService<ProjectResource,
           ProjectResourceDto,
           Guid, 
           PagedAndSortedResultRequestDto, 
           CreateProjectResourceDto, 
           UpdateProjectResourceDto>,
       IProjectResourceService
    {
        public ProjectResourceService(IRepository<ProjectResource, Guid> repository) : base(repository)
        {

        }
    }
}
