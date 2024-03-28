using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class ClientFeedback : Entity<Guid>
    {
        public FeedbackType FeedbackType { get; set; }
        public DateTime DateReceived { get; set; }
        public required string DetailedFeedback { get; set; }
        public bool ActionTaken { get; set; }
        public DateTime? ClosureDate { get; set; }

        [ForeignKey("Projects")]
        public Guid ProjectId { get; set; }


        public Project? Project { get; set; }
    }
}