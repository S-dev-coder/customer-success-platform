using Volo.Abp.Domain.Entities.Auditing;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class Phase : AuditedEntity<Guid>
    {
        public string Name { get; set; }
        public Guid ProjectId { get; set; } 
        public Project? Project { get; set; }
        public ICollection<ApprovedTeam>? ApprovedTeam { get; set; }
    }
}


