namespace Promact.CustomerSuccess.Platform.Services.Dtos.ProjectResources
{
    public class CreateProjectResourceDto
    {
        public Guid ResourceId { get; set; }
        public virtual Guid Resource { get; set; }
        public double AllocationPercentage { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public required string Role { get; set; }
        public string? Comment { get; set; }
    }
}
