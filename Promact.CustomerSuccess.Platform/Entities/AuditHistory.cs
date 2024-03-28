using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class AuditHistory : AuditedEntity<Guid>
    {
        [ForeignKey(nameof(Project))]
        public Guid ProjectId { get; set; }
        public DateTime? DateOfAudit { get; set; }
        public Guid? ReviewedBy { get; set; }
        public string? Status { get; set; }
        public string? ReviewedSection { get; set; }
        public string? Comments { get; set; }
        public string? ActionItem { get; set; }
    }
}


