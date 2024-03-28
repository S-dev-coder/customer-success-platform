namespace Promact.CustomerSuccess.Platform.Services.Dtos.EscalationMatrices
{
    public class CreateEscalationMatrixDto
    {
        public required string PersonName { get; set; }
        public EscalationMatrixLevels Level { get; set; }
        public EscalationType EscalationType { get; set; }
        public required Guid ProjectId { get; set; }
    }
}
