﻿using ChattingApp.Domain.Models;

namespace ChattingApp.Resource.Follow
{
    public class FollowDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string KnownAs { get; set; }
        public int age { get; set; }
        public string? PhotoURL { get; set; }
    }
}
