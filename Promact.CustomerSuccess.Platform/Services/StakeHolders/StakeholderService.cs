using AutoMapper;
using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos.Stakeholders;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services.StakeHolders
{
    public class StakeholderService : CrudAppService<Stakeholder,StakeholderDto,Guid, PagedAndSortedResultRequestDto,CreateStakeholderDto,UpdateStakeholderDto>, IStakeholderService
    {
        private readonly IMapper _mapper;
        public StakeholderService(IRepository<Stakeholder, Guid> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        // get all stakeholders by project id
        public async Task<List<StakeholderDto>> GetByProjectIdAsync(Guid projectId)
        {
            var stakeholders = await Repository.GetListAsync(x => x.ProjectId == projectId);
            return _mapper.Map<List<Stakeholder>, List<StakeholderDto>>(stakeholders);
        }
    }
}
