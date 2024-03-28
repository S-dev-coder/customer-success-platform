using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class ProjectBudget : AuditedEntity<Guid>
    {        
        public ProjectType Type { get; set; }
        public int? DurationInMonths { get; set; }
        public int? BudgetedHours { get; set; }
        [ForeignKey(nameof(Project))]
        public Guid ProjectId { get; set; }
        public virtual Project? Project { get; set; }
    }
}

