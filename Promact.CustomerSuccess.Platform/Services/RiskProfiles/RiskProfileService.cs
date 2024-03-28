using AutoMapper;
using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos.RiskProfiles;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services.RiskProfiles
{
    public class RiskProfileService : CrudAppService<RiskProfile, RiskProfileDto,Guid, PagedAndSortedResultRequestDto, CreateRiskProfileDto,UpdateRiskProfileDto>, IRiskProfileService
    {
        private readonly IMapper _mapper;
        public RiskProfileService(IRepository<RiskProfile, Guid> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        // get all risk profiles by project id
        public async Task<List<RiskProfileDto>> GetByProjectIdAsync(Guid projectId)
        {
            var riskProfiles = await Repository.GetListAsync(x => x.ProjectId == projectId);
            return _mapper.Map<List<RiskProfile>, List<RiskProfileDto>>(riskProfiles);
        }
    }
}
