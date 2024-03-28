using Promact.CustomerSuccess.Platform.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Application.Dtos;
namespace Promact.CustomerSuccess.Platform.Services.Dtos.ProjectBudgets
{
    public class ProjectBudgetDto : IEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public ProjectType Type { get; set; }
        public int? DurationInMonths { get; set; }
        public int? BudgetedHours { get; set; }
        public Guid ProjectId { get; set; }
        public virtual Project? Project { get; set; }
    }
}

