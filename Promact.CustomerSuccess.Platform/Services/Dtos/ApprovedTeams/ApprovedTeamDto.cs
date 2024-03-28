using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.ApprovedTeams
{
    public class ApprovedTeamDto : IEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public int NoOfResources { get; set; }
        public string Role { get; set; }
        public int Availablity { get; set; }
        public int Duration { get; set; }
        public Guid PhaseId { get; set; }
    }
}


