using AutoMapper;
using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos.VersionHistories;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services.VersionHistories
{
    
    public class VersionHistoryService : CrudAppService<VersionHistory,
                               VersionHistoryDto,
                               Guid,
                               PagedAndSortedResultRequestDto,
                               CreateVersionHistoryDto,
                               UpdateVersionHistoryDto>,
                               IVersionHistoryService
    {
        private readonly IMapper _mapper;
        public VersionHistoryService(IRepository<VersionHistory, Guid> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        // get by project id
        public async Task<List<VersionHistoryDto>> GetByProjectIdAsync(Guid projectId)
        {
            var versionHistories = await Repository.GetListAsync(x => x.ProjectId == projectId);
            return _mapper.Map<List<VersionHistory>, List<VersionHistoryDto>>(versionHistories);
        }
    }
}
