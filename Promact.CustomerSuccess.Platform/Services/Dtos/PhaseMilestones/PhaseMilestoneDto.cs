using Promact.CustomerSuccess.Platform.Entities;
using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.PhaseMilestones
{
    public class PhaseMilestoneDto : EntityDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public required string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public required string Description { get; set; }
        public required string Comments { get; set; }
        public MilestoneOrPhaseStatus Status { get; set; }
        public virtual Project? Project { get; set; }
        public virtual ICollection<Sprint>? Sprints { get; set; }
    }
}
