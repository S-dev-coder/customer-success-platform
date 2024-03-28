namespace Promact.CustomerSuccess.Platform.Services.Dtos.ApprovedTeams
{
    public class CreateApprovedTeamDto
    {
        public int NoOfResources { get; set; }
        public string Role { get; set; }
        public int Availablity { get; set; }
        public int Duration { get; set; }
        public Guid PhaseId { get; set; }
    }
}
