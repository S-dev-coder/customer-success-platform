﻿using Promact.CustomerSuccess.Platform.Entities;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.Sprints
{
    public class CreateSprintDto
    {
        public Guid PhaseMilestoneId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SprintStatus Status { get; set; }
        public required string Comments { get; set; }
        public required string Goals { get; set; }
        public int SprintNumber { get; set; }
    }
}
