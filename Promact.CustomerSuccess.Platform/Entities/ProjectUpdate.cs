using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class ProjectUpdate: AuditedEntity<Guid>
    {
        public Guid ProjectId { get; set; }

        public DateTime Date { get; set; }

        public required string GeneralUpdates { get; set; }
    }
}
