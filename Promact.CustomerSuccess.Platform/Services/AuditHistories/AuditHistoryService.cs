using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos.AuditHistories;
using AutoMapper;



namespace Promact.CustomerSuccess.Platform.Services.AuditHistories
{

    public class AuditHistoryService : 
        CrudAppService<
            AuditHistory, 
            AuditHistoryDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateAuditHistoryDto, 
            UpdateAuditHistoryDto>, 
        IAuditHistoryService
    {
        private readonly IMapper _mapper;
        public AuditHistoryService(IRepository<AuditHistory, Guid> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public async Task<List<AuditHistoryDto>> GetByProjectIdAsync(Guid projectId)
        {
            var versionHistories = await Repository.GetListAsync(x => x.ProjectId == projectId);
            // map using automapper
            return _mapper.Map<List<AuditHistoryDto>>(versionHistories);
        }
    }
}
