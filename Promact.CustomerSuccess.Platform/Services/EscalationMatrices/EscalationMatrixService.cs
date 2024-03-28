using AutoMapper;
using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos;
using Promact.CustomerSuccess.Platform.Services.Dtos.EscalationMatrices;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services.EscalationMatrices
{
    public class EscalationMatrixService :CrudAppService<EscalationMatrix, EscalationMatrixDto, Guid, PagedAndSortedResultRequestDto, CreateEscalationMatrixDto, UpdateEscalationMatrixDto>, IEscalationMatrixService
    {
        private readonly IMapper _mapper;
        public EscalationMatrixService(IRepository<EscalationMatrix, Guid> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        // get all by project id
        public async Task<List<EscalationMatrixDto>> GetByProjectIdAsync(Guid projectId)
        {
            var escalationMatrices = await Repository.GetListAsync(x => x.ProjectId == projectId);
            return _mapper.Map<List<EscalationMatrix>, List<EscalationMatrixDto>>(escalationMatrices);
        }
    }
}
