using Promact.CustomerSuccess.Platform.Services.Dtos.AuditHistories;
using Promact.CustomerSuccess.Platform.Services.Dtos.ClientFeedbacks;
using Promact.CustomerSuccess.Platform.Services.Dtos.Documents;
using Promact.CustomerSuccess.Platform.Services.Dtos.MeetingMinutes;
using Promact.CustomerSuccess.Platform.Services.Dtos.PhaseMilestones;
using Promact.CustomerSuccess.Platform.Services.Dtos.ProjectBudgets;
using Promact.CustomerSuccess.Platform.Services.Dtos.ProjectResources;
using Promact.CustomerSuccess.Platform.Services.Dtos.RiskProfiles;
using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.Projects
{
    public class ProjectDto : IEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public  string Manager { get; set; }
        public DateTime CreationTime { get; protected set; }
        public IEnumerable<DocumentDto>? Documents { get; set; }
        public IEnumerable<ProjectBudgetDto>? Budgets { get; set; }
        public IEnumerable<EscalationMatrixDto>? EscalationMatrices { get; set; }
        public IEnumerable<RiskProfileDto>? RiskProfiles { get; set; }
        public IEnumerable<PhaseMilestoneDto>? PhaseMilestones { get; set; }
        public IEnumerable<ProjectResourceDto>? Resources { get; set; }
        public IEnumerable<ClientFeedbackDto>? ClientFeedbacks { get; set; }
        public IEnumerable<MeetingMinuteDto>? MeetingMinutes { get; set; }
        public IEnumerable<AuditHistoryDto>? AuditHistories { get; set; }

    }
}
