using Promact.CustomerSuccess.Platform.Entities;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.RiskProfiles
{
    public class RiskProfileDto : IEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public RiskType RiskType { get; set; }
        public RiskType Description { get; set; }
        public string Severity { get; set; }
        public RiskImpact Impact { get; set; }
        public string Status { get; set; }
        public DateTime ClosureDate { get; set; }
        public virtual ICollection<RemediationStep>? RemediationSteps { get; set; }
        public virtual Project? Project { get; set; }
    }
}