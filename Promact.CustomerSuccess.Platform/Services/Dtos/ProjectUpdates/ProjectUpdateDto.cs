using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.ProjectUpdates
{
    public class ProjectUpdateDto : IEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }

        public DateTime Date { get; set; }

        public required string GeneralUpdates { get; set; }
    }
}
