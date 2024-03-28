using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class ApprovedTeam : AuditedEntity<Guid>
    {
        public int NoOfResources { get; set; }
        public string Role { get; set; }
        public int Availablity { get; set; }
        public int Duration { get; set; }
        [ForeignKey("Phase")]
        public Guid PhaseId { get; set; }
    }
}
