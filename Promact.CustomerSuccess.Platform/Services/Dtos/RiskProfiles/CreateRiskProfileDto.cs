using Promact.CustomerSuccess.Platform.Entities;
using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.RiskProfiles
{
    public class CreateRiskProfileDto 
    {
        public Guid ProjectId { get; set; }
        public RiskType RiskType { get; set; }
        public RiskType Description { get; set; }
        public string Severity { get; set; }
        public RiskImpact Impact { get; set; }
        public string Status { get; set; }
        public DateTime ClosureDate { get; set; }
    }
}
