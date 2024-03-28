using System.ComponentModel.DataAnnotations.Schema;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.Stakeholders
{
    public class CreateStakeholderDto
    {
        public required string Title { get; set; }
        public required string Name { get; set; }
        public string? Contact { get; set; }
        public Guid ProjectId { get; set; }
    }
}
