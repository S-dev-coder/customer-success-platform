﻿namespace Promact.CustomerSuccess.Platform.Services.Dtos.MeetingMinutes
{
    public class UpdateMeetingMinuteDto
    {
        public Guid ProjectId { get; set; }
        public required DateTime MeetingDate { get; set; }
        public required string MoMLink { get; set; }
        public required string Comments { get; set; }

        public int Duration { get; set; }
    }
}
