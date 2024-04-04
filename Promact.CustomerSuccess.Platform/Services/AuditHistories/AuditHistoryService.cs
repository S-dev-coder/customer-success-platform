using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos.AuditHistories;
using AutoMapper;
using Promact.CustomerSuccess.Platform.Services.EmailNotifications;
using Promact.CustomerSuccess.Platform.Services.Dtos.EmailNotifications;
using Promact.CustomerSuccess.Platform.Data;
using Microsoft.EntityFrameworkCore;



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
        private readonly IEmailNotificationService _emailNotificationService;
        private readonly IRepository<Stakeholder, Guid> _stackholderRepository;
        private readonly PlatformDbContext _dbContext;
        public AuditHistoryService(IRepository<AuditHistory, Guid> repository, IMapper mapper, IRepository<Stakeholder, Guid> stackholderRepository, IEmailNotificationService emailNotificationService, PlatformDbContext platformDbContext) : base(repository)
        {
            _mapper = mapper;
            _stackholderRepository = stackholderRepository;
            _emailNotificationService = emailNotificationService;
            _dbContext = platformDbContext;
        }
        public override async Task<AuditHistoryDto> CreateAsync(CreateAuditHistoryDto input)
        {
            var auditHistory = _mapper.Map<AuditHistory>(input);
            await Repository.InsertAsync(auditHistory);

            // get all stakeholders by project id
            var project = await _dbContext.Projects.FirstOrDefaultAsync(x => x.Id == auditHistory.ProjectId);
            var notificationData = new NotificationDataDto
            {
                Subject = "Audit History Created",
                Message = $"Audit History Created for Project {project.Name}"
            };
            await _emailNotificationService.SandNotificationsToStakeHolders(auditHistory.ProjectId, notificationData);
            return _mapper.Map<AuditHistoryDto>(auditHistory);
        }
        public override async Task<AuditHistoryDto> UpdateAsync(Guid id, UpdateAuditHistoryDto input)
        {
            var stackholder = await base.UpdateAsync(id, input);
            var project = await _dbContext.Projects.FirstOrDefaultAsync(x => x.Id == stackholder.ProjectId);
            var notificationData = new NotificationDataDto
            {
                Subject = "Audit History Updated",
                Message = $"Audit History Updated for Project {project.Name}"
            };
            await _emailNotificationService.SandNotificationsToStakeHolders(stackholder.ProjectId, notificationData);
            return stackholder;
        }
        public override async Task DeleteAsync(Guid id)
        {
            
            var auditHistory = await _dbContext.Stakeholders.FirstOrDefaultAsync(x => x.Id == id);
            await base.DeleteAsync(id);
            var project = await _dbContext.Projects.FirstOrDefaultAsync(x => x.Id == auditHistory.ProjectId);
            var notificationData = new NotificationDataDto
            {
                Subject = "Audit History Deleted",
                Message = $"Audit History Deleted for Project {project.Name}"
            };
            await _emailNotificationService.SandNotificationsToStakeHolders(auditHistory.ProjectId, notificationData);
        }
        public async Task<List<AuditHistoryDto>> GetByProjectIdAsync(Guid projectId)
        {
            var versionHistories = await Repository.GetListAsync(x => x.ProjectId == projectId);
            // map using automapper
            return _mapper.Map<List<AuditHistoryDto>>(versionHistories);
        }
    }
}
