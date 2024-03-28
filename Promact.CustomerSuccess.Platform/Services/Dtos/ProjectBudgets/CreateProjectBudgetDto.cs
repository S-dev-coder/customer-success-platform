namespace Promact.CustomerSuccess.Platform.Services.Dtos.ProjectBudgets
{
    public class CreateProjectBudgetDto
    {
        public ProjectType Type { get; set; }
        public int? DurationInMonths { get; set; }
        public int? BudgetedHours { get; set; }
        public Guid ProjectId { get; set; }
    }
}