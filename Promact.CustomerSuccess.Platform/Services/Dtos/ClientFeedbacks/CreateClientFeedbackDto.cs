﻿using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.ClientFeedbacks
{
    public class CreateClientFeedbackDto
    {
        public Guid ProjectId { get; set; }


        public DateTime DateReceived { get; set; } = DateTime.Now;
        public FeedbackType FeedbackType { get; set; }
        public required string DetailedFeedback { get; set; }
        public bool ActionTaken { get; set; }
        public DateTime? ClosureDate { get; set; }




    }

}
